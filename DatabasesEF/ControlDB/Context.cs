﻿using DatabasesEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasesEF.ControlDB
{
    public class ContextMoney : DbContext
    {
        public ContextMoney()
        {
        }

        public ContextMoney(DbContextOptions<ContextMoney> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.db.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ApiBd");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<MoneyControl> RegistryMoneyControl { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new MoneyControlConfiguration().Configure(modelBuilder.Entity<MoneyControl>());
        }

    }
}
