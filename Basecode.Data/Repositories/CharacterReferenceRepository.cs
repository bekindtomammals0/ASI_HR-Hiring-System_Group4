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
    /// Repository class to interact with the 'CharacterReference' entity in the database.
    /// </summary>
    public class CharacterReferenceRepository : BaseRepository, ICharacterReferenceRepository
    {
        private readonly BasecodeContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterReferenceRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work instance used for transaction management.</param>
        /// <param name="context">The database context instance.</param>
        public CharacterReferenceRepository(IUnitOfWork unitOfWork, BasecodeContext context) : base(unitOfWork)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all Character References from the database.
        /// </summary>
        /// <returns>An <see cref="IQueryable{CharacterReference}"/> containing all Character References.</returns>
        public IQueryable<CharacterReference> RetrieveAll()
        {
            return this.GetDbSet<CharacterReference>();
        }

        /// <summary>
        /// Adds a new Character Reference to the database.
        /// </summary>
        /// <param name="characterReference">The Character Reference entity to be added.</param>
        public void Add(CharacterReference characterReference)
        {
            _context.CharacterReference.Add(characterReference);
            _context.SaveChanges();
        }

        /// <summary>
        /// Retrieves a Character Reference from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Character Reference to retrieve.</param>
        /// <returns>The Character Reference entity if found; otherwise, null.</returns>
        public CharacterReference GetById(int id)
        {
            return _context.CharacterReference.Find(id);
        }

        /// <summary>
        /// Updates an existing Character Reference in the database.
        /// </summary>
        /// <param name="characterReference">The updated Character Reference entity.</param>
        public void Update(CharacterReference characterReference)
        {
            _context.CharacterReference.Update(characterReference);
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a Character Reference from the database based on its ID.
        /// </summary>
        /// <param name="id">The ID of the Character Reference to delete.</param>
        public void Delete(int id)
        {
            var data = _context.CharacterReference.Find(id);
            if (data != null)
            {
                _context.CharacterReference.Remove(data);
                _context.SaveChanges();
            }
        }
    }
}
