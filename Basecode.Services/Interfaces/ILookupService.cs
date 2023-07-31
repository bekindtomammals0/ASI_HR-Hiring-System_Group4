using Basecode.Data.Interfaces;
using Basecode.Data.Models;

namespace Basecode.Services.Interfaces
{
    public interface ILookupService
    {
        List<ExperienceLevel> GetExperienceLevels();
        List<EmploymentType> GetEmploymentTypes();
        List<CivilStatus> GetCivilStatuses();
    }
}