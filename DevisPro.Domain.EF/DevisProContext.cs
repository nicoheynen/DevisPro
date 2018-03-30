using DevisPro.Domain.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevisPro.Domain
{
    public class DevisProContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DevisProContext(DbContextOptions<DevisProContext> options) : base(options)
        {

        }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .OwnsOne((x) => x.Address);
        }
    }

    public class DevisProContextFactory
    {
        public static DevisProContext Create()
        {
            //Normaal moet connectionString uit configs komen
            var connectionString =
                @"Data Source=.\sqlexpress;Initial Catalog=DevisPro;Integrated Security=True";
            var options = new DbContextOptionsBuilder<DevisProContext>()
                .UseSqlServer(connectionString);

            return new DevisProContext(options.Options);

        }
    }

}
