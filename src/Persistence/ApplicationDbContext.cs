using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {

        // Represents an Activities table in the database
        public DbSet<Activity> Activities { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}