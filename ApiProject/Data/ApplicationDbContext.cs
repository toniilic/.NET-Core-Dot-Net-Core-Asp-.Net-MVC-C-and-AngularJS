using Microsoft.EntityFrameworkCore;
using ApiProject.Models;

namespace ApiProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SampleModel> SampleModels { get; set; }
    }
}
