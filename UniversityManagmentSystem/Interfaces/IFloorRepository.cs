using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagementSystem.Interfaces
{
    public interface IFloorRepository : IBaseRepository<Floor>
    {
        void Save();
    }
}
