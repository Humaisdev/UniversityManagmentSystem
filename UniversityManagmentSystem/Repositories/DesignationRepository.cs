using UniversityManagementSystem.Database;
using UniversityManagmentSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class DesignationRepository : BaseRepository<Model.Designation> , IDesignationRepository
    {
        private readonly UniversityDbContext _dbContext;
        public DesignationRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
