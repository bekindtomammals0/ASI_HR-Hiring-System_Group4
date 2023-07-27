using Basecode.Data.Models;

namespace Basecode.Data.Interfaces
{
    public interface IEmploymentTypeRepository
    {
        IQueryable<EmploymentType> RetrieveAll();
    }
}