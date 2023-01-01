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
            return await studentDbcontext.students.ToListAsync();
            
        }

        
    }
}
