using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Repositories
{
    public class RoomTypeAllocationRepository : BaseRepository<RoomTypeAllocation>, IRoomTypeAllocationRepository
    {
        private readonly UniversityDbContext _dbContext;
        public RoomTypeAllocationRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
