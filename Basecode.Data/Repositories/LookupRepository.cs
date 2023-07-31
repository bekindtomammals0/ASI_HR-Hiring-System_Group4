using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Basecode.Data.Repositories
{
    public class LookupRepository : BaseRepository, ILookupRepository
    {
        private readonly BasecodeContext _context;
        public LookupRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }
        public IEnumerable<EmploymentType> GetEmploymentTypes()
        {
            return this.GetDbSet<EmploymentType>();
        }
        public IEnumerable<ExperienceLevel> GetExperienceLevels()
        {
            return this.GetDbSet<ExperienceLevel>();
        }
        public IEnumerable<ProcessStatus> GetProcessStatuses()
        {
            return this.GetDbSet<ProcessStatus>();
        }
        public IEnumerable<CivilStatus> GetCivilStatuses()
        {
            return this.GetDbSet<CivilStatus>();
        }
    }
}
