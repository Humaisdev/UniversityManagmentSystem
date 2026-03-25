using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        void Save();
    }
}
