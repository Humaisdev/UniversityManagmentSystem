using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Repositories
{
    public class UserRightRepository : BaseRepository<UserRight>, IUserRightRepository
    {
        private readonly UniversityDbContext _dbContext;
        public UserRightRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
