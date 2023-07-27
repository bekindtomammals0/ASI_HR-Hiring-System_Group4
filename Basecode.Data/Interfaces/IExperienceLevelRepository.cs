using Basecode.Data.Models;

namespace Basecode.Data.Interfaces
{
    public interface IExperienceLevelRepository
    {
        IEnumerable<ExperienceLevel> RetrieveAll();
    }
}