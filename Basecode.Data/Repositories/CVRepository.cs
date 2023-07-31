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
    /// Repository class to interact with the 'CV' entity in the database.
    /// </summary>
    public class CVRepository : BaseRepository, ICVRepository
    {
        private readonly BasecodeContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CV"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work instance used for transaction management.</param>
        /// <param name="context">The database context instance.</param>
        public CVRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all CV from the database.
        /// </summary>
        /// <returns>An <see cref="IQueryable{CV}"/> containing all CVs.</returns>
        public IQueryable<CV> RetrieveAll()
        {
            return this.GetDbSet<CV>();
        }

        /// <summary>
        /// Adds a new CV to the database.
        /// </summary>
        /// <param name="cv">The CV entity to be added.</param>
        public void Add(CV cv)
        {
            _context.CV.Add(cv);
            _context.SaveChanges();
        }

        /// <summary>
        /// Retrieves a CV from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the CV to retrieve.</param>
        /// <returns>The CV entity if found; otherwise, null.</returns>
        public CV GetById(int id)
        {
            return _context.CV.Find(id);
        }

        /// <summary>
        /// Updates an existing CV in the database.
        /// </summary>
        /// <param name="cv">The updated CV entity.</param>
        public void Update(CV cv)
        {
            _context.CV.Update(cv);
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a CV from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the CV to delete.</param>
        public void Delete(int id)
        {
            var data = _context.CV.Find(id);
            if (data != null)
            {
                _context.CV.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
