using Basecode.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Basecode.Data
{
    public class BasecodeContext : IdentityDbContext<IdentityUser>
    {
        public BasecodeContext (DbContextOptions<BasecodeContext> options)
            : base(options)
        {}

        public void InsertNew(RefreshToken token)
        {
            var tokenModel = RefreshToken.SingleOrDefault(i => i.Username == token.Username);
            if (tokenModel != null)
            {
                RefreshToken.Remove(tokenModel);
                SaveChanges();
            }
            RefreshToken.Add(token);
            SaveChanges();
        }
        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<CharacterReference> CharacterReference { get; set; }
        public virtual DbSet<CivilStatus> CivilStatus { get; set; }
        public virtual DbSet<CV> CV { get; set; }
        public virtual DbSet<ExperienceLevel> ExperienceLevel {get; set; }
        public virtual DbSet<EmploymentType> EmploymentType { get; set; }
        public virtual DbSet<JobOpening> JobOpening { get; set; }
        public virtual DbSet<ProcessStatus> ProcessStatus { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}