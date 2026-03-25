using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Repositories
{
    public class UserTypeAllocationRepository : BaseRepository<UserTypeAllocation>, IUserTypeAllocationRepository
    {
        private readonly UniversityDbContext _dbContext;
        public UserTypeAllocationRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
