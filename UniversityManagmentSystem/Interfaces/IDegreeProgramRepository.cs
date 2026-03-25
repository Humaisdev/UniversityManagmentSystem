using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IDegreeProgramRepository : IBaseRepository<DegreeProgram>
    {
        void Save();
    }
}
