using Microsoft.EntityFrameworkCore;
using Student_Project.Models.Domain;
using Student_Project.StudentDbcontext;

namespace Student_Project.Repository
{
    public class studentRepository : IstudentRepository
    {
        private readonly studentDbcontext studentDbcontext;

        public studentRepository(studentDbcontext studentDbcontext)
        {
            this.studentDbcontext = studentDbcontext;
        }
        public async Task<IEnumerable<Student>> GetAll()
        {
            var record = await studentDbcontext.students.ToListAsync();
            foreach(var i in record)
            {
                if(i.section=="")
                {
                    i.section = "NA";
                }
                if(i.year_of_enrollment == 0)
                {
                    i.year_of_enrollment = 2020;
                }
            }
            return record;
            
        }

        
    }
}
