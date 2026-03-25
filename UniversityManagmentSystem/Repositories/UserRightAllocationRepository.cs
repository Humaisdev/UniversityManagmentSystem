using UniversityManagementSystem.Database;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Repositories
{
    public class UserRightAllocationRepository : BaseRepository<UserRightAllocation>, Interfaces.IUserRightAllocationRepository
    {
        private readonly UniversityDbContext _dbContext;
        public UserRightAllocationRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
