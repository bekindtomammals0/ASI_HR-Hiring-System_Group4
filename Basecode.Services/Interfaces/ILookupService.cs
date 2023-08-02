using Basecode.Data.Interfaces;
using Basecode.Data.Models;

namespace Basecode.Services.Interfaces
{
    public interface ILookupService
    {
        List<CivilStatus> GetCivilStatuses();
        List<EmploymentType> GetEmploymentTypes();
        List<ExperienceLevel> GetExperienceLevels();
        List<ProcessStatus> GetProcessStatuses();
    }
}