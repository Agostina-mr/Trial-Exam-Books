using AuthorApi.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthorApi.Database
{
    public class AuthorDbContext :DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\agosm\RiderProjects\Trial-Exam-Books\AuthorApi\Database\AuthorDatabase.db");
        }
    }
    
    
}