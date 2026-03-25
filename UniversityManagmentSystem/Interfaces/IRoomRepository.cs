using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagementSystem.Interfaces
{
    public interface IRoomRepository : IBaseRepository<Room>
    {
        void Save();
    }
}
