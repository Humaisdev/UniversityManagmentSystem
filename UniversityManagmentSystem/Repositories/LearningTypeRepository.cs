using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class LearningTypeRepository : BaseRepository<Model.LearningType>, ILearningTypeRepository
    {
        private readonly UniversityDbContext _dbContext;
        public LearningTypeRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
