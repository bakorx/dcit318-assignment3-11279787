using System;

namespace StudentGradingSystem.Exceptions
{
    public class StudentMissingFieldException : Exception
    {
        public StudentMissingFieldException(string message) : base(message)
        {
        }
    }
}