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
    public class ApplicantService : IApplicantService
    {
        private readonly IApplicantRepository _repository;

        private readonly IMapper _mapper;
        public ApplicantService(IApplicantRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<Applicant> RetrieveAll()
        {
            var data = _repository.RetrieveAll().Select(s => new Applicant
            {
                Id = s.Id,
                UserID = s.UserID,
                CivilStatusID = s.CivilStatusID,
                CVId = s.CVId,
                JobOpeningID = s.JobOpeningID,
                CharacterReferenceID = s.CharacterReferenceID,
                ProcessStatusID = s.ProcessStatusID,
                CharacterReferenceResponded = s.CharacterReferenceResponded,
                ContactNo = s.ContactNo
            }).ToList();
            return data;
        }
        public void Add(Applicant applicant)
        {
            _repository.Add(applicant);
        }

        public Applicant GetById(int id)
        {
            var data = _mapper.Map<Applicant>(_repository.GetById(id));
            return data;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
