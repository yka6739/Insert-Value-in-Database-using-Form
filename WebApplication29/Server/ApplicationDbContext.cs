using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication29.Shared.Entities;

namespace WebApplication29.Server
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Online>().HasKey(x => new { x.Id });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Online> Genres { get; set; }
    }
}
