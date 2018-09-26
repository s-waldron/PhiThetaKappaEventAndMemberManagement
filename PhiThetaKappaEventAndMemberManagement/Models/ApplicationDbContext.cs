using Microsoft.EntityFrameworkCore;

namespace PhiThetaKappaEventAndMemberManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }

        public DbSet<Events> Events { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<News> News { get; set; }
    }// end ApplicationDbContext class
}// end PhiThetaKappaEventAndMemberManagement.Models namespace
