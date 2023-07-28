using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Interfaces
{
    public interface ICharacterReferenceRepository
    {
        IQueryable<CharacterReference> RetrieveAll();
        void Add(CharacterReference characterReference);
        CharacterReference GetById(int id);
        void Update(CharacterReference characterReference);
        void Delete(int id);
    }
}
