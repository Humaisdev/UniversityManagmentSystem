using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
using UniversityManagmentSystem.Model;
namespace UniversityManagmentSystem.Repositories
{
    public class PLORepository : BaseRepository<PLO>, IPLORepository
    {
        private readonly UniversityDbContext _dbContext;
        public PLORepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
