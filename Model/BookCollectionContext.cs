using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookCollection.Model
{
    public partial class BookCollectionContext : DbContext
    {
        public BookCollectionContext()
        {
        }

        public BookCollectionContext(DbContextOptions<BookCollectionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ScannedBooks> ScannedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=BookCollection;User Id=webuser;Password=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
