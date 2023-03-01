using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerCrudTest.Model.Entity;

namespace CustomerCrudTest.Model.Context
{
    public class CustomerContext:DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<CustomerTypes> CustomerTypes { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           

            //  modelBuilder.Entity<Customers>()
            // .HasOne<CustomerTypes>(c => c.CustomerTypes)
            // .WithMany()
            // .HasForeignKey(c => c.CustomerTypeId);

            //  modelBuilder.Entity<Invoice>()
            // .HasOne<Customers>(i => i.Customers)
            // .WithMany()
            // .HasForeignKey(i => i.CustomerId);

            // modelBuilder.Entity<InvoiceDetail>()
            //.HasOne(p => p.Customers)
            //.WithMany()
            //.HasForeignKey(p => p.CustomerId);

        }
    }
}
