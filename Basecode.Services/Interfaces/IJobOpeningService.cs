using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Services.Interfaces
{
    public interface IJobOpeningService
    {
        List<JobOpeningViewModel> RetrieveAll();
        void Add(JobOpening jobOpening);
        JobOpeningViewModel GetById(int id);
        void Update(JobOpening jobOpening);
        void Delete(int id);
    }
}
