using AutoMapper;
using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.SqlServer.Server;
using System.Linq;

namespace Basecode.Services.Services
{
    public class CVService : ICVService
    {
        private readonly ICVRepository _repository;

        private readonly IMapper _mapper;
        public CVService(ICVRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<CV> RetrieveAll()
        {
            var data = _repository.RetrieveAll().Select(s => new CV
            {
                Id = s.Id,
                File = s.File
            }).ToList();
            return data;
        }
        public void Add(CV cv)
        {
            _repository.Add(cv);
        }

        public CV GetById(int id)
        {
            var data = _mapper.Map<CV>(_repository.GetById(id));
            return data;
        }

    }
}
