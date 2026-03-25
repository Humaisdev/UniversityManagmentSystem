using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class StructureUnitRepository : BaseRepository<Model.StructureUnit>, IStructureUnitRepository
    {
        private readonly UniversityDbContext _dbContext;
        public StructureUnitRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
