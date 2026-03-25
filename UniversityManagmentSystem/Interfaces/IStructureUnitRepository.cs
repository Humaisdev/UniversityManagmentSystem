using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IStructureUnitRepository : IBaseRepository<StructureUnit>
    {
        void Save();
    }
}
