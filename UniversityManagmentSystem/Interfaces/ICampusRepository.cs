using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagementSystem.Interfaces
{
    public interface ICampusRepository : IBaseRepository<Campus>
    {
        void Save();
    }
}
