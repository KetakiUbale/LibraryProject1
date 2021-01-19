using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.Model
{


        public class BookContext : DbContext

        {

            public DbSet<Book> Books { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<FeeStatus> FeeStatuses { get; set; }
            public DbSet<BookType> BookTypes { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                string conn = "Data Source=K-S-K\\SQLEXPRESS01;Initial Catalog=Book;Integrated Security = true;MultipleActiveResultSets=True";
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(conn);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Book>().HasOne(b => b.BookType).WithMany(b => b.Books).HasForeignKey(b => b.BookTypeId).OnDelete(DeleteBehavior.NoAction);

                modelBuilder.Entity<Book>().HasOne(b => b.Author).WithMany(b => b.Books).HasForeignKey(b => b.AuthorId).OnDelete(DeleteBehavior.NoAction);

                modelBuilder.Entity<Book>().HasOne(b => b.FeeStatus).WithMany(b => b.Books).HasForeignKey(b => b.FeeStatusId).OnDelete(DeleteBehavior.NoAction);

            }

        
    }
}

