using Microsoft.EntityFrameworkCore;
using Student_Project.Models.Domain;

namespace Student_Project.StudentDbcontext
{
    public class studentDbcontext :DbContext
    {
        public studentDbcontext(DbContextOptions<studentDbcontext> options):base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
