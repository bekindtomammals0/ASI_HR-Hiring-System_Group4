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
        List<CharacterReferenceViewModel> RetrieveAll();
        void Add(CharacterReference characterReference);
        CharacterReferenceViewModel GetById(int id);
        void Update(CharacterReference characterReference);
        void Delete(int id);
    }
}
