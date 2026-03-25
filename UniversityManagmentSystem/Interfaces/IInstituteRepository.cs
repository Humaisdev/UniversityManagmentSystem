using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IInstituteRepository : IBaseRepository<Institute>
    {
        void Save();
    }
}
