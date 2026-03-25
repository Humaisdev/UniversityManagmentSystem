using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface ICourseSchemeRepository : IBaseRepository<CourseScheme>
    {
        void Save();
    }
}
