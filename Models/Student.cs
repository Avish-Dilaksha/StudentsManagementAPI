namespace StudentsManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Class { get; set; } = default!;
        public int Age { get; set; }
        public int MentorId { get; set; }
    }
}
