using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IBlockRepository : IBaseRepository<Block>
    {
        void Save();
    }
}
