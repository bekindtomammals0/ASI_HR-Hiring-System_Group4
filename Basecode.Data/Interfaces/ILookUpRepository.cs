using Basecode.Data.Models;

namespace Basecode.Data.Interfaces
{
    public interface ILookUpRepository
    {
        IEnumerable<ExperienceLevel> GetAllExperienceLevels();
        IEnumerable<EmploymentType> GetAllEmploymentTypes();
    }
}