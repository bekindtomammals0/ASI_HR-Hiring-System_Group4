
using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Basecode.Services.Interfaces;

namespace Basecode.Services.Services
{
    public class LookupService : ILookupService
    {
        private readonly ILookupRepository _repository;
        public LookupService(ILookupRepository repository )
        {
            _repository = repository;
        }

        public List<ExperienceLevel> GetExperienceLevels()
        {
            return _repository.GetExperienceLevels().ToList();
        }
        public List<EmploymentType> GetEmploymentTypes()
        {
            return _repository.GetEmploymentTypes().ToList();
        }
        public List<CivilStatus> GetCivilStatuses()
        {
            return _repository.GetCivilStatuses().ToList();
        }
    }
}
