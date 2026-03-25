using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Repositories
{
    public class FloorRepository : BaseRepository<Floor>, IFloorRepository
    {
        private readonly UniversityDbContext _dbContext;
        public FloorRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
