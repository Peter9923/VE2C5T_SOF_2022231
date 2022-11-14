using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VE2C5T_SOF_2022231.Models;

namespace VE2C5T_SOF_2022231.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<AppUser>? Users { get; set; }
        public virtual DbSet<Question>? Questions { get; set; }
        public virtual DbSet<Answer>? Answers { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}