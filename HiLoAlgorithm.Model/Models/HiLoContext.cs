using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiLoAlgorithm.Model.Models
{
    public class HiLoContext:DbContext
    {
        public HiLoContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //use this to configure the contex
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
            //modelBuilder.HasSequence<int>("DBSequenceHiLo")
            //      .StartsAt(1000).IncrementsBy(5);
            //modelBuilder.ForSqlServerUseSequenceHiLo("DBSequenceHiLo");
            //modelBuilder.Entity<User>().Property(u=>u.ID).ForSqlServerUseSequenceHiLo();
            modelBuilder.Entity<User>().Property(u => u.ID).UseHiLo();
            modelBuilder.Entity<Author>().Property(a => a.AuthorId).UseHiLo();
            modelBuilder.Entity<Book>().Property(b => b.BookId).UseHiLo();
            modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
