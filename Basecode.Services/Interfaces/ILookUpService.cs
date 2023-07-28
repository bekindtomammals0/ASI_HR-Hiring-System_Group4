using Basecode.Data.Models;

public interface ILookUpService
{
    List<EmploymentType> GetAllEmploymentTypes();
    List<ExperienceLevel> GetAllExperienceLevels();
}