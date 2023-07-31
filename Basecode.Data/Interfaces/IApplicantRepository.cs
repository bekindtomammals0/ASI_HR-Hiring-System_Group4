using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Interfaces
{
    public interface IApplicantRepository
    {
        IQueryable<Applicant> RetrieveAll();
        void Add(Applicant applicant);
        Applicant GetById(int id);
        void Update(Applicant applicant);
        void Delete(int id);
    }
}
