using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Basecode.Data.Repositories
{
    public class LookUpRepository : BaseRepository, ILookUpRepository
    {
        private readonly BasecodeContext _context;
        public LookUpRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }
        public IEnumerable<EmploymentType> GetAllEmploymentTypes()
        {
            return this.GetDbSet<EmploymentType>();
        }
        public IEnumerable<ExperienceLevel> GetAllExperienceLevels()
        {
            return this.GetDbSet<ExperienceLevel>();
        }

    }
}
