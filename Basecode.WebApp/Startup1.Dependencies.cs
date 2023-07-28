using Basecode.WebApp.Authentication;
using Basecode.Data;
using Basecode.Data.Interfaces;
using Basecode.Data.Repositories;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;

namespace Basecode.WebApp
{
    public partial class Startup1
    {
        private void ConfigureDependencies(IServiceCollection services)
        {            
            // Common
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ClaimsProvider, ClaimsProvider>();

            // Services 
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobOpeningService, JobOpeningService>();
            services.AddScoped<IEmploymentTypeService, EmploymentTypeService>();
            services.AddScoped<IExperienceLevelService, ExperienceLevelService>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddScoped<IAdminService, AdminService>();

            // Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJobOpeningRepository, JobOpeningRepository>();
            services.AddScoped<IEmploymentTypeRepository, EmploymentTypeRepository>();
            services.AddScoped<IExperienceLevelRepository, ExperienceLevelRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();

        }
    }
}