using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Repositories
{
    public class JobOpeningRepository : BaseRepository, IJobOpeningRepository
    {
        private readonly BasecodeContext _context;
        public JobOpeningRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }

        public IQueryable<JobOpening> RetrieveAll()
        { 
            return this.GetDbSet<JobOpening>();
        }

        public void Add(JobOpening jobOpening)
        { 
            _context.JobOpenings.Add(jobOpening);
            _context.SaveChanges();
        }

        public JobOpening GetById(int id)
        {
            return _context.JobOpenings.Find(id);
        }

        public void Update(JobOpening jobOpening) 
        {
            _context.JobOpenings.Update(jobOpening);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _context.JobOpenings.Find(id);
            if (data != null)
            {
                _context.JobOpenings.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
