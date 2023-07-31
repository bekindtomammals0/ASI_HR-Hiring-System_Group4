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
    /// Repository class to interact with the 'Applicant' entity in the database.
    /// </summary>
    public class ApplicantRepository : BaseRepository, IApplicantRepository
    {
        private readonly BasecodeContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work instance used for transaction management.</param>
        /// <param name="context">The database context instance.</param>
        public ApplicantRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all Applicants from the database.
        /// </summary>
        /// <returns>An <see cref="IQueryable{Applicant}"/> containing all Applicants.</returns>
        public IQueryable<Applicant> RetrieveAll()
        {
            return this.GetDbSet<Applicant>();
        }

        /// <summary>
        /// Adds a new Applicant to the database.
        /// </summary>
        /// <param name="applicant">The Applicant entity to be added.</param>
        public void Add(Applicant applicant)
        {
            _context.Applicant.Add(applicant);
            _context.SaveChanges();
        }

        /// <summary>
        /// Retrieves an Applicant from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Applicant to retrieve.</param>
        /// <returns>The Applicant entity if found; otherwise, null.</returns>
        public Applicant GetById(int id)
        {
            return _context.Applicant.Find(id);
        }

        /// <summary>
        /// Updates an existing Applicant in the database.
        /// </summary>
        /// <param name="applicant">The updated Applicant entity.</param>
        public void Update(Applicant applicant)
        {
            _context.Applicant.Update(applicant);
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a Applicant from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Applicant to delete.</param>
        public void Delete(int id)
        {
            var data = _context.Applicant.Find(id);
            if (data != null)
            {
                _context.Applicant.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
