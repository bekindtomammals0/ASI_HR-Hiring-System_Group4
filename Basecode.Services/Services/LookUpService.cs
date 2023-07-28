using Basecode.Data.Interfaces;
using Basecode.Data.Models;

namespace Basecode.Services.Services
{
    public class LookUpService : ILookUpService
    {
        private readonly ILookUpRepository _repository;

        public LookUpService(ILookUpRepository repository)
        {
            _repository = repository;  
        }

        public List<EmploymentType> GetAllEmploymentTypes()
        {
            return _repository.GetAllEmploymentTypes().ToList();
        }
        public List<ExperienceLevel> GetAllExperienceLevels()
        {
            return _repository.GetAllExperienceLevels().ToList();
        }
    }
}