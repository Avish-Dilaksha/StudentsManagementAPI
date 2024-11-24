namespace StudentsManagementAPI.Models
{
    public class Mentor
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Student>? Students { get; set; }
    }
}
