using Basecode.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Basecode.WebApp
{
    public partial class Startup1
    {
        private void ConfigureDatabase(IServiceCollection services)
        {
            services.AddDbContext<BasecodeContext>(
            options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."),
                    optionsAction => { }
                )
            );


            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<BasecodeContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();      
        }
    }
}