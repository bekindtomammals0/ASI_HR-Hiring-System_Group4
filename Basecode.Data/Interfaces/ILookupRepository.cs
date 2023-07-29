using Basecode.Data.Models;

namespace Basecode.Data.Interfaces
{
    public interface ILookupRepository
    {
        IEnumerable<EmploymentType> GetEmploymentTypes();
        IEnumerable<ExperienceLevel> GetExperienceLevels();
        IEnumerable<CivilStatus> GetCivilStatuses();
    }
}