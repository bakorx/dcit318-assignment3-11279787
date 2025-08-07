namespace StudentGradingSystem.Models
{
    public class Student
    {
        public string Name { get; }
        public string Id { get; }
        public int Score { get; }

        public Student(string name, string id, int score)
        {
            Name = name;
            Id = id;
            Score = score;
        }
    }
}