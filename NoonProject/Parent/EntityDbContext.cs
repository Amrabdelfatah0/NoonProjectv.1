using Microsoft.EntityFrameworkCore;
using NoonProject.Models.Client;
using NoonProject.Models.Seller;
using NoonProject.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Parent
{
    public class EntityDbContext:DbContext

    {
        public DbSet<Seller>? Seller { get; set;}
        public DbSet<Client>? Client { get; set; }
        public DbSet<User>? User { get; set; }

        public const string ConnectionString = "server=(localDb)\\MSSQLLocalDB;Database=EntityDb;Trusted_connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

    }
}
