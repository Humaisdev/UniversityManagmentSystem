using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Repositories
{
    public class CampusRepository : BaseRepository<Campus>, ICampusRepository
    {
        private readonly UniversityDbContext _dbContext;
        public CampusRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
