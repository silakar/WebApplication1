using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ContactsAPIDbContext:DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Contacts> Contacts { get; set; }



    }
}
