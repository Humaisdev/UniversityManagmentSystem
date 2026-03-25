using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class PLOToCLORepository : BaseRepository<Model.PLOToCLO>, IPLOToCLORepository
    {
        private readonly UniversityDbContext _dbContext;
        public PLOToCLORepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
