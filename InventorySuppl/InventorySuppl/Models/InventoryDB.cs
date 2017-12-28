using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace InventorySuppl.Models
{
    public class InventoryDB: DbContext
    {
        public InventoryDB() : base("name=InventoryDB")
        {
    //        Database.SetInitializer(new DropCreateDatabaseIfModelChanges<InventoryDB>());
        }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<typeOfItems>  TypesOfItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<LocArea> LocAreas { get; set; }
        public DbSet<LocUnit> LocUnits { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<UserP> UserPs { get; set; }
        public DbSet<TypeOfRight> TypesOfRight { get; set; }
        public DbSet<Operation> Operations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ManufacturerMap());
            modelBuilder.Configurations.Add(new LocAreaMap());
            modelBuilder.Configurations.Add(new UserPMap());
            modelBuilder.Configurations.Add(new VendorMap());
        }
    }
    
}