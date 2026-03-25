using UniversityManagementSystem.Model;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Model;

namespace UniversityManagementSystem.Interfaces
{
    public interface IFacultyCampusRepository : IBaseRepository<FacultyCampus>
    {
        void Save();
    }
}
