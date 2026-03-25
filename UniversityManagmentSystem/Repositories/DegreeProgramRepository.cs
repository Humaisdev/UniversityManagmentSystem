using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class DegreeProgramRepository : BaseRepository<Model.DegreeProgram>, IDegreeProgramRepository
    {
        private readonly UniversityDbContext _dbContext;
        public DegreeProgramRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
