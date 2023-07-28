
using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Basecode.Services.Interfaces;

namespace Basecode.Services.Services
{
    public class ExperienceLevelService : IExperienceLevelService
    {
        private readonly IExperienceLevelRepository _repository;
        public ExperienceLevelService(IExperienceLevelRepository repository )
        {
            _repository = repository;
        }

        public List<ExperienceLevel> GetAllExperienceLevels()
        {
            var data = _repository.RetrieveAll().ToList();
            return data;
        }
    }
}
