using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Services.Interfaces
{
    public interface IApplicantService
    {
        List<Applicant> RetrieveAll();
        void Add(Applicant applicant);
        Applicant GetById(int id);
        void Delete(int id);
    }
}
