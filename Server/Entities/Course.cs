namespace Server.Entities
{
    public sealed class Course : Entity<int>
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public int? TeacherId { get; set; }
        public int? DepartmentId { get; set; }

        public Teacher Teacher { get; set; }
        public Department Department { get; set; }
    }
}