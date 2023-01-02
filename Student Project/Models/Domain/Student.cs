namespace Student_Project.Models.Domain
{
    public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public long rollno { get; set; }
        public int studentClass { get; set; }

        public string section { get; set; }

        public int year_of_enrollment { get; set; }
    }
}
