using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class DepartmentRepository : BaseRepository<Model.Department>, IDepartmentRepository
    {
        private readonly UniversityDbContext _dbContext;
        public DepartmentRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
