using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagementSystem.Interfaces
{
    public interface IRoomTypeAllocationRepository : IBaseRepository<RoomTypeAllocation>
    {
        void Save();
    }
}
