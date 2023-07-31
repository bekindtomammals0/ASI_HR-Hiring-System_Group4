using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Services.Interfaces
{
    public interface ICVService
    {
        List<CV> RetrieveAll();
        void Add(CV cv);
        CV GetById(int id);
    }
}
