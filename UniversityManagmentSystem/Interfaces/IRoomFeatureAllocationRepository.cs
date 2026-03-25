using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagementSystem.Interfaces
{
    public interface IRoomFeatureAllocationRepository : IBaseRepository<RoomFeatureAllocation>
    {
        void Save();
    }
}
