using Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basecode.Data.Interfaces
{
    public interface ICVRepository
    {
        IQueryable<CV> RetrieveAll();
        void Add(CV cv);
        CV GetById(int id);
        void Update(CV cv);
        void Delete(int id);
    }
}
