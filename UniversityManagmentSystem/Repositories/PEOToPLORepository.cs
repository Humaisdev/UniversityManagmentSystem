using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class PEOToPLORepository : BaseRepository<Model.PEOToPLO>, IPEOToPLORepository
    {
        private readonly UniversityDbContext _dbContext;
        public PEOToPLORepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
