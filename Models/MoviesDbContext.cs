using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ec.Models;

namespace ec.Models
{
    public class MoviesDbContext :DbContext
    {
        //public DbSet<Movie> Movies { get; set; }
        //public DbSet<Publisher> Publisher { get; set; }
     

        // public DbSet<People> People { get; set; }
        /**//*   public DbSet<Book> Books { get; set; }

         */




        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>()
                .HasMany(c => c.Employees)
                .WithOne(e => e.Company)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }

        public DbSet<y> y { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        

        public virtual DbSet<People> People { get; set; }
}
}
