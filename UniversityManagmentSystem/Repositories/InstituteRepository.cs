using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class InstituteRepository : BaseRepository<Model.Institute>, IInstituteRepository
    {
        private readonly UniversityDbContext _dbContext;
        public InstituteRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
