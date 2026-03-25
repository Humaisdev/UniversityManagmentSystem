using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IPLOToCLORepository : IBaseRepository<PLOToCLO>
    {
        void Save();
    }
}
