using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface ILearningLevelRepository : IBaseRepository<LearningLevel>
    {
        void Save();
    }
}
