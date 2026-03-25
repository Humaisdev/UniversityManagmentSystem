using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IPEOToPLORepository : IBaseRepository<PEOToPLO>
    {
        void Save();
    }
}
