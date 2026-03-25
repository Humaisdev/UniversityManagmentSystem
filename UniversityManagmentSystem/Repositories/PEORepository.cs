using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class PEORepository : BaseRepository<Model.PEO>, IPEORepository
    {
        private readonly UniversityDbContext _dbContext;
        public PEORepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
