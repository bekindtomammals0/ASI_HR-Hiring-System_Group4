using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Basecode.Data.Repositories
{
    public class EmploymentTypeRepository : BaseRepository, IEmploymentTypeRepository
    {
        private readonly BasecodeContext _context;
        public EmploymentTypeRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }
        public IEnumerable<EmploymentType> RetrieveAll()
        {
            return this.GetDbSet<EmploymentType>();
        }
    }
}
