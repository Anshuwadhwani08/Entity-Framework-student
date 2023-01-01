using Student_Project.Models.Domain;

namespace Student_Project.Repository
{
    public interface IstudentRepository
    {
       Task <IEnumerable<Student>> GetAll();
    }
}
