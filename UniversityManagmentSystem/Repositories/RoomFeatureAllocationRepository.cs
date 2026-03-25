using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;
namespace UniversityManagmentSystem.Repositories
{
    public class RoomFeatureAllocationRepository : BaseRepository<RoomFeatureAllocation>, IRoomFeatureAllocationRepository
    {
        private readonly UniversityDbContext _dbContext;
        public RoomFeatureAllocationRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
