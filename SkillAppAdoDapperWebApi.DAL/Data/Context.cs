using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Data
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SHOP2;Integrated Security=True;");
        }


        public DbSet<SQLCustomer> Customer { get; set; }
        public DbSet<SQLOrder> Order { get; set; }
        public DbSet<SQLToy> Toy { get; set; }
        public DbSet<SQLTOYDet> TOYDet { get; set; }
        public DbSet<SQLVendor> Vendor { get; set; }
        public DbSet<SQLVENDORDet> VENDORDet { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //            Customers
            modelBuilder.Entity<SQLCustomer>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<SQLCustomer>()
                .HasMany(c => c.SQLOrder);

             
            //              Toy
            modelBuilder.Entity<SQLToy>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<SQLToy>()
                .HasMany(c => c.SQLOrder);



            //             order
            modelBuilder.Entity<SQLOrder>()
                .HasKey(c => new { c.Id });

            modelBuilder.Entity<SQLOrder>()
                .HasOne(c => c.SQLCustomer)
                .WithMany(aa => aa.SQLOrder)
                .HasForeignKey(p => p.CustomerID)
                .HasPrincipalKey(m => m.Id);

            modelBuilder.Entity<SQLOrder>()
                .HasOne(c => c.SQLToy)
                .WithMany(aa => aa.SQLOrder)
                .HasForeignKey(p => p.ToyID)
                .HasPrincipalKey(m => m.Id);


           
        }
    }
}

