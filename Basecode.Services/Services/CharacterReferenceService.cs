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
    public class CharacterReferenceService : ICharacterReferenceService
    {
        private readonly ICharacterReferenceRepository _repository;

        private readonly IMapper _mapper;
        public CharacterReferenceService(ICharacterReferenceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<CharacterReference> RetrieveAll()
        {
            var data = _repository.RetrieveAll().Select(s => new CharacterReference
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
            _repository.Add(characterReference);
        }

        public CharacterReference GetById(int id)
        {
            var data = _mapper.Map<CharacterReference>(_repository.GetById(id));
            return data;
        }

        public void Update(CharacterReference characterReference)
        {
            var charRef = _repository.GetById(characterReference.Id);

            charRef.Id = characterReference.Id;
            charRef.Email = characterReference.Email;
            charRef.FirstName = characterReference.FirstName;
            charRef.LastName = characterReference.LastName;
            charRef.Responded = characterReference.Responded;

            _repository.Update(charRef);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
