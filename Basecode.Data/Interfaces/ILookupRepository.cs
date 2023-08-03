using Basecode.Data.Models;

namespace Basecode.Data.Interfaces
{
    public interface ILookupRepository
    {
        IEnumerable<CivilStatus> GetCivilStatuses();
        IEnumerable<EmploymentType> GetEmploymentTypes();
        IEnumerable<ExperienceLevel> GetExperienceLevels();
        IEnumerable<ProcessStatus> GetProcessStatuses();

    }
}