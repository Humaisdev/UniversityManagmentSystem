using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class LearningLevelRepository : BaseRepository<Model.LearningLevel>, ILearningLevelRepository
    {
        private readonly UniversityDbContext _dbContext;
        public LearningLevelRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
