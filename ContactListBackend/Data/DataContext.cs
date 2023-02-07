using ContactListBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactListBackend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Contact> contacts { get; set; }

    }
}

