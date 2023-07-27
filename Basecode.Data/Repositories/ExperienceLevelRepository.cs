using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Basecode.Data.Repositories
{
    public class ExperienceLevelRepository : BaseRepository, IExperienceLevelRepository
    {
        private readonly BasecodeContext _context;
        public ExperienceLevelRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }
        public IQueryable<ExperienceLevel> RetrieveAll()
        {
            return this.GetDbSet<ExperienceLevel>();
        }
    }
}
