using AutoMapper;
using Basecode.Data.Interfaces;
using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Basecode.Services.Services
{
    public class CharacterReferenceService : ICharacterReferenceService
    {
        private readonly ICharacterReferenceRepository _CRrepository;
        private readonly IMapper _mapper;

        public CharacterReferenceService(ICharacterReferenceRepository repository, IMapper mapper)
        {
            _CRrepository = repository;
            _mapper = mapper;
        }

        public List<CharacterReferenceViewModel> RetrieveAll()
        {
            var data = _CRrepository.RetrieveAll().Select(s => new CharacterReferenceViewModel
            {
                Id = s.Id,
                Email = s.Email,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Responded = s.Responded
            }).ToList();
            return data;
        }

        public void Add(CharacterReference characterReference)
        {
            _CRrepository.Add(characterReference);
        }

        public CharacterReferenceViewModel GetById(int id)
        {
            var data = _mapper.Map<CharacterReferenceViewModel>(_CRrepository.GetById(id));
            return data;
        }

        public void Update(CharacterReference characterReference)
        {
            var characterRef = _CRrepository.GetById(characterReference.Id);
            if (characterRef != null)
            {
                characterRef.Email = characterReference.Email;
                characterRef.FirstName = characterReference.FirstName;
                characterRef.LastName = characterReference.LastName;
                characterRef.Responded = characterReference.Responded;

                _CRrepository.Update(characterRef);
            }
            else
            {
                throw new ArgumentException("Character Reference not found.");
            }
        }

        public void Delete(int id)
        {
            _CRrepository.Delete(id);
        }
    }
}
