using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Repositories
{
    public class UserTypeRepository : BaseRepository<UserType>, IUserTypeRepository
    {
        private readonly UniversityDbContext _dbContext;
        public UserTypeRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
