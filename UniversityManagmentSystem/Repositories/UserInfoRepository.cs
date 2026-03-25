using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.Repositories
{
    public class UserInfoRepository : BaseRepository<UserInfo>, IUserInfoRepository
    {
        private readonly UniversityDbContext _dbContext;
        public UserInfoRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
