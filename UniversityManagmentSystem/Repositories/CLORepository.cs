using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
namespace UniversityManagmentSystem.Repositories
{
    public class CLORepository : BaseRepository<Model.CLO>, ICLORepository
    {
        private readonly UniversityDbContext _dbContext;
        public CLORepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
