using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;
namespace UniversityManagmentSystem.Repositories
{
    public class FacultyCampusRepository : BaseRepository<Model.FacultyCampus>, IFacultyCampusRepository
    {
        private readonly UniversityDbContext _dbContext;
        public FacultyCampusRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
