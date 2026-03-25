using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class BuildingRepository : BaseRepository<Model.Building>, IBuildingRepository
    {
        private readonly UniversityDbContext _dbContext;
        public BuildingRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
