using AutoMapper;
using Basecode.Data.Interfaces;
using Basecode.Data.Models;

namespace Basecode.Services.Interfaces
{
    public interface IExperienceLevelService
    {
        List<ExperienceLevel> RetrieveAll();

    }
}