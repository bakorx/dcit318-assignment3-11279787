using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public class HealthSystemApp
    {
        private Repository<Patient> _patientRepo = new Repository<Patient>();
        private Repository<Prescription> _prescriptionRepo = new Repository<Prescription>();
        private Dictionary<int, List<Prescription>> _prescriptionMap = new Dictionary<int, List<Prescription>>();

        public void SeedData()
        {
            _patientRepo.Add(new Patient(1, "Kwame Mensah", 35, "Male"));
            _patientRepo.Add(new Patient(2, "Akosua Boateng", 29, "Female"));
            _patientRepo.Add(new Patient(3, "Yaw Owusu", 42, "Male"));

            _prescriptionRepo.Add(new Prescription(1, 1, "Paracetamol", DateTime.Now.AddDays(-5)));
            _prescriptionRepo.Add(new Prescription(2, 2, "Amoxicillin", DateTime.Now.AddDays(-3)));
            _prescriptionRepo.Add(new Prescription(3, 1, "Ibuprofen", DateTime.Now.AddDays(-1)));
            _prescriptionRepo.Add(new Prescription(4, 3, "Cough Syrup", DateTime.Now));
            _prescriptionRepo.Add(new Prescription(5, 2, "Antibiotics", DateTime.Now.AddDays(-2)));
        }

        public void BuildPrescriptionMap()
        {
            _prescriptionMap = _prescriptionRepo.GetAll()
                .GroupBy(p => p.PatientId)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public void PrintAllPatients()
        {
            Console.WriteLine("=== All Patients ===");
            foreach (var patient in _patientRepo.GetAll())
            {
                Console.WriteLine(patient);
            }
        }

        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            return _prescriptionMap.ContainsKey(patientId) ? _prescriptionMap[patientId] : new List<Prescription>();
        }

        public void PrintPrescriptionsForPatient(int patientId)
        {
            Console.WriteLine($"\nPrescriptions for Patient ID {patientId}:");
            var prescriptions = GetPrescriptionsByPatientId(patientId);

            if (prescriptions.Count == 0)
            {
                Console.WriteLine("No prescriptions found.");
            }
            else
            {
                foreach (var p in prescriptions)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
