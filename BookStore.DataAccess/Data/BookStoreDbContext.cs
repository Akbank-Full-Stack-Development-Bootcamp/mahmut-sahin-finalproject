using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Data
{
    public class BookStoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookStoreDbContext()
        {

        }
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                        .HasOne(b => b.Genre)
                        .WithMany(g => g.Books)
                        .HasForeignKey(b => b.GenreId);
            modelBuilder.Entity<Book>()
                        .HasMany<Author>(b => b.Authors)
                        .WithMany(a => a.Books);
                        


            //modelBuilder.Entity<BookAuthor>()
            //            .HasKey(ba => new { ba.AuthorId, ba.BookId });
            //modelBuilder.Entity<BookAuthor>()
            //            .HasOne(ba => ba.Author)
            //            .WithMany(aut => aut.Books)
            //            .HasForeignKey(ba => ba.BookId);
            //modelBuilder.Entity<BookAuthor>()
            //            .HasOne(ba => ba.Book)
            //            .WithMany(ba => ba.Authors)
            //            .HasForeignKey(ba => ba.AuthorId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
