using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Services.Interfaces
{
    public interface ICharacterReferenceService
    {
        List<CharacterReference> RetrieveAll();
        void Add(CharacterReference characterReference);
        CharacterReference GetById(int id);
    }
}
