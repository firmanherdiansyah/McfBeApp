using McfBeApp.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace McfBeApp.Api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options) { }

        public DbSet<BpkpTransaction> BpkpTransaction { get; set; }

        public DbSet<StorageLocation> StorageLocation { get; set; }
    }
}
