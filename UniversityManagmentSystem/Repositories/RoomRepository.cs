using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagementSystem.Model;

namespace UniversityManagmentSystem.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        private readonly UniversityDbContext _dbContext;
        public RoomRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
