using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Repositories
{
    /// <summary>
    /// Repository class to interact with the 'JobOpening' entity in the database.
    /// </summary>
    public class JobOpeningRepository : BaseRepository, IJobOpeningRepository
    {
        private readonly BasecodeContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="JobOpeningRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work instance used for transaction management.</param>
        /// <param name="context">The database context instance.</param>
        public JobOpeningRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all Job Openings from the database.
        /// </summary>
        /// <returns>An <see cref="IQueryable{JobOpening}"/> containing all Job Openings.</returns>
        public IQueryable<JobOpening> RetrieveAll()
        {
            return this.GetDbSet<JobOpening>();
        }

        /// <summary>
        /// Adds a new Job Opening to the database.
        /// </summary>
        /// <param name="jobOpening">The Job Opening entity to be added.</param>
        public void Add(JobOpening jobOpening)
        {
            _context.JobOpening.Add(jobOpening);
            _context.SaveChanges();
        }

        /// <summary>
        /// Retrieves a Job Opening from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Job Opening to retrieve.</param>
        /// <returns>The Job Opening entity if found; otherwise, null.</returns>
        public JobOpening GetById(int id)
        {
            return _context.JobOpening.Find(id);
        }

        /// <summary>
        /// Updates an existing Job Opening in the database.
        /// </summary>
        /// <param name="jobOpening">The updated Job Opening entity.</param>
        public void Update(JobOpening jobOpening)
        {
            _context.JobOpening.Update(jobOpening);
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a Job Opening from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Job Opening to delete.</param>
        public void Delete(int id)
        {
            var data = _context.JobOpening.Find(id);
            if (data != null)
            {
                _context.JobOpening.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
