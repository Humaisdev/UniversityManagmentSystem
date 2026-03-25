using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
namespace UniversityManagmentSystem.Repositories
{
    public class CLOToSubjectRepository : BaseRepository<Model.CLOToSubject>, ICLOToSubjectRepository
    {
        private readonly UniversityDbContext _dbContext;
        public CLOToSubjectRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
