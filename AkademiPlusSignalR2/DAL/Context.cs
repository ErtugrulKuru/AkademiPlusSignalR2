using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusSignalR2.DAL
{
    public class Context:DbContext        
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JH4NS85;initial catalog=DbSignalR2;integrated security=true");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
