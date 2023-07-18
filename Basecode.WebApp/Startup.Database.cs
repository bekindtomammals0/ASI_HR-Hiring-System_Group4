using Basecode.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Basecode.WebApp
{
    public partial class Startup
    {
        private void ConfigureDatabase(IServiceCollection services)
        {
            string server = Environment.GetEnvironmentVariable("DB_NAME");
            string database = Environment.GetEnvironmentVariable("DB_NAME");
            string username = Environment.GetEnvironmentVariable("DB_USER");
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(database) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // All environment variables are set, use them to construct the connection string
                string connectionString = $"Server={server};Database={database};User Id={username};Password={password};Trusted_Connection=True;MultipleActiveResultSets=true";
                services.AddDbContext<BasecodeContext>(options =>
                    options.UseSqlServer(connectionString, optionsAction => { })
                );
            }
            else
            {
                // Use the default connection string configuration from appsettings.json or throw an exception if not found
                services.AddDbContext<BasecodeContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."),
                        optionsAction => { }
                    )
                );
            }

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<BasecodeContext>()
                    .AddDefaultTokenProviders();      
        }
    }
}