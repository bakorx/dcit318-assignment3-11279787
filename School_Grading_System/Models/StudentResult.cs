namespace StudentGradingSystem.Models
{
    public class StudentResult
    {
        public string StudentName { get; }
        public string StudentId { get; }
        public string GradeLetter { get; }

        public StudentResult(string name, string id, string grade)
        {
            StudentName = name;
            StudentId = id;
            GradeLetter = grade;
        }
    }
}