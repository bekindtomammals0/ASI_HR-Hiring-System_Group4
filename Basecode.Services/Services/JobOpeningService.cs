using AutoMapper;
using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using System.Linq;

namespace Basecode.Services.Services
{
    public class JobOpeningService : IJobOpeningService
    {
        private readonly IJobOpeningRepository _repository;
        private readonly IMapper _mapper;
        public JobOpeningService(IJobOpeningRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<JobOpeningViewModel> RetrieveAll()
        {
            var data = _repository.RetrieveAll().Select(s => new JobOpeningViewModel
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                EmploymentType = s.EmploymentType,
                ExperienceLevel = s.ExperienceLevel,
            }).ToList();
            return data;
        }

        public void Add(JobOpening jobOpening)
        {
            jobOpening.CreatedBy = System.Environment.UserName;
            jobOpening.UpdatedBy = System.Environment.UserName;
            jobOpening.CreatedTime = DateTime.Now;
            jobOpening.UpdatedTime = DateTime.Now;
            _repository.Add(jobOpening);
        }

        public JobOpeningViewModel GetById(int id)
        {
            var data = _mapper.Map<JobOpeningViewModel>(_repository.GetById(id));
            return data;
        }

        public void Update(JobOpening jobOpening)
        {
            var job = _repository.GetById(jobOpening.Id);
            job.Title = jobOpening.Title;
            job.Description = jobOpening.Description;
            job.EmploymentType = jobOpening.EmploymentType;
            job.ExperienceLevel = jobOpening.ExperienceLevel;
            job.UpdatedBy = System.Environment.UserName;
            job.UpdatedTime = DateTime.Now;
            _repository.Update(job);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
