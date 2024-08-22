using Microsoft.EntityFrameworkCore;
using Sozinho03.Domain.Model;
using System.Data.Common;

namespace Sozinho03.Infrastructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public object Employee { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql
            (
                "Server=localhost;" +
                "Port=7777;Database=employee;" +
                "User Id=postgres;" +
                "Password=2653"
            );
    }
}
