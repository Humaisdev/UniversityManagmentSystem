using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface ICLOToSubjectRepository : IBaseRepository<CLOToSubject>
    {
        void Save();
    }
}
