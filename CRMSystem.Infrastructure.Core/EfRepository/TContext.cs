using CRMSystem.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMSystem.Infrastructure
{
    public class TContext : DbContext
    {

        public TContext(DbContextOptions<TContext> options):base(options)
        { 
        
        }


        public DbSet<User> AppUsers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
