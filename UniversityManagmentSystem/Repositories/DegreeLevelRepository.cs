using UniversityManagementSystem.Database;
using UniversityManagmentSystem.Interfaces;
namespace UniversityManagmentSystem.Repositories
{
    public class DegreeLevelRepository : BaseRepository<Model.DegreeLevel>, IDegreeLevelRepository
    {
        private readonly UniversityDbContext _dbContext;
        public DegreeLevelRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
