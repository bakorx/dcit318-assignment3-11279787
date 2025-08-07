using System;
using StudentGradingSystem.Models;
using StudentGradingSystem.Processors;
using StudentGradingSystem.Exceptions;

namespace StudentGradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Kwame Bakor", "UG123456", 85);
            var processor = new StudentResultProcessor();

            try
            {
                var result = processor.ProcessResult(student);
                Console.WriteLine($"Student: {result.StudentName}\nID: {result.StudentId}\nGrade: {result.GradeLetter}");
            }
            catch (StudentMissingFieldException mfEx)
            {
                Console.WriteLine("Missing field error: " + mfEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}