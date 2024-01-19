using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
namespace CURDusingEF.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public virtual DbSet<AccountModel> AccountModel { get; set; }

        public virtual DbSet<BookingModel> BookingModel { get; set; }

        public virtual DbSet<Contact> Contact { get; set; }
    }
}
