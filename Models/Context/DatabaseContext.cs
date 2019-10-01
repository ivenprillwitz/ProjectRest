using ProjectRest.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectRest {
    public class DatabaseContext : DbContext {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}