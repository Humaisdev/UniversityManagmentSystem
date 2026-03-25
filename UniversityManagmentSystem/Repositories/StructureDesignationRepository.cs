using UniversityManagementSystem.Database;
using UniversityManagementSystem.Interfaces;

namespace UniversityManagmentSystem.Repositories
{
    public class StructureDesignationRepository : BaseRepository<Model.StructureDesignation>, IStructureDesignationRepository
    {
        private readonly UniversityDbContext _dbContext;
        public StructureDesignationRepository(UniversityDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
