using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;
using UniversityManagmentSystem.Models;

namespace UniversityManagementSystem.Interfaces
{
    public interface IUserRightRepository : IBaseRepository<UserRight>
    {
        void Save();
    }
}
