using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IUserRightAllocationRepository : IBaseRepository<UserRightAllocation>
    {
        void Save();
    }
}
