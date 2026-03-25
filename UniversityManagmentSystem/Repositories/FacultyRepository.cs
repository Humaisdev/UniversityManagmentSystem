using UniversityManagementSystem.Database;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class FacultyRepository : BaseRepository<Model.Faculty>, IFacultyRepository
    {
        private readonly UniversityDbContext _dbContext;
        public FacultyRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
