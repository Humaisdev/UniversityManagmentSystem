using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface ILearningTypeRepository : IBaseRepository<LearningType>
    {
        void Save();
    }
}
