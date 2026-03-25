using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IBuildingRepository : IBaseRepository<Building>
    {
        void Save();
    }
}
