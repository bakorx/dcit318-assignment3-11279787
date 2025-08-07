using StudentGradingSystem.Models;
using StudentGradingSystem.Exceptions;

namespace StudentGradingSystem.Processors
{
    public class StudentResultProcessor
    {
        public StudentResult ProcessResult(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.Name) || string.IsNullOrWhiteSpace(student.Id))
            {
                throw new StudentMissingFieldException("Missing one or more required fields.");
            }

            string grade = student.Score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };

            return new StudentResult(student.Name, student.Id, grade);
        }
    }
}