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
    public class JobOpeningService : IJobOpeningService
    {
        private readonly IJobOpeningRepository _JOrepository;

        private readonly IMapper _mapper;
        public JobOpeningService(IJobOpeningRepository repository, IMapper mapper)
        {
            _JOrepository = repository;
            _mapper = mapper;
        }

        public List<JobOpeningViewModel> RetrieveAll()
        {
            var data = _JOrepository.RetrieveAll().Select(s => new JobOpeningViewModel
            {
                Id = s.Id,
                Title = s.Title,
                Description = s.Description,
                EmploymentTypeID = s.EmploymentTypeID,
                ExperienceLevelID = s.ExperienceLevelID,
            }).ToList();
            return data;
        }
        public void Add(JobOpening jobOpening)
        {
            jobOpening.CreatedTime = DateTime.Now;
            jobOpening.UpdatedTime = DateTime.Now;
            _JOrepository.Add(jobOpening);
        }

        public JobOpeningViewModel GetById(int id)
        {
            var data = _mapper.Map<JobOpeningViewModel>(_JOrepository.GetById(id));
            return data;
        }

        public void Update(JobOpening jobOpening)
        {
            var job = _JOrepository.GetById(jobOpening.Id);
            job.Title = jobOpening.Title;
            job.Description = jobOpening.Description;
            job.EmploymentTypeID = jobOpening.EmploymentTypeID;
            job.ExperienceLevelID = jobOpening.ExperienceLevelID;
            job.UpdatedBy = System.Environment.UserName;
            job.UpdatedTime = DateTime.Now;
            _JOrepository.Update(job);
        }

        public void Delete(int id)
        {
            _JOrepository.Delete(id);
        }
    }
}
