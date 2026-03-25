using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
namespace UniversityManagmentSystem.Repositories
{
    public class CourseSchemeRepository : BaseRepository<Model.CourseScheme>, ICourseSchemeRepository
    {
        private readonly UniversityDbContext _dbContext;
        public CourseSchemeRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
