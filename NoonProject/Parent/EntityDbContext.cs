﻿using Microsoft.EntityFrameworkCore;
using NoonProject.Models;
using NoonProject.Models.Address;
using NoonProject.Models.Communication;
using NoonProject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonProject.Parent
{
    public class EntityDbContext:DbContext

    {
        public DbSet<Governrote> governrotes { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Mobile> mobiles { get; set; }
        public DbSet<Addres> addresses { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<User>? User { get; set; }

        public const string ConnectionString = "server=(localDb)\\MSSQLLocalDB;Database=EntityDb;Trusted_connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
       
    }
}
