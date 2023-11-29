using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Laundromat
{
	public class LaundromatContext : DbContext
    {
        // Created a data structure of dbset
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<EquipmentUsage> EquipmentUsages { get; set; }
        public string DbPath { get; private set; }


        //Added microsoft entityframework nuget packages of core and coredesign Sqlite 
        public LaundromatContext()
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Laundromats.db");
        }


        //This method is telling to use Sqlite and telling where that file is located
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}

