namespace WebApplication1.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string phone { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
