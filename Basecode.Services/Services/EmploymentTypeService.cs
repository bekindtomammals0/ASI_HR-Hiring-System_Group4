using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Basecode.Services.Interfaces;

namespace Basecode.Services.Services
{
    public class EmploymentTypeService : IEmploymentTypeService
    {
        private readonly IEmploymentTypeRepository _repository;
        public EmploymentTypeService(IEmploymentTypeRepository repository)
        {
            _repository = repository;
        }

        public List<EmploymentType> RetrieveAll()
        {
            var data = _repository.RetrieveAll().ToList();
            return data;
        }
    }
}
