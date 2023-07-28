using AutoMapper;
using Basecode.Data.Interfaces;
using Basecode.Data.Models;

namespace Basecode.Services.Interfaces
{
    public interface IEmploymentTypeService
    {
        List<EmploymentType> GetAllEmploymentTypes();
    }
}