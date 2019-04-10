using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using TiC_BigSchool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Tic_BigSchool.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CateGory> CateGories { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Attendance>().HasRequired(a => a.Course).WithMany().WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
       }
    }
}