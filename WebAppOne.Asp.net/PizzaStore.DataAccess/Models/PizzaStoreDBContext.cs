using Microsoft.EntityFrameworkCore;
using PizzaStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace PizzaStore.DataAccess.Models
{
    public class PizzaStoreDBContext : DBContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=samuelsqlserver.database.windows.net;database=SamuelsqlPizzaStore;user=sqladmin;password=***********;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pizza>().Hashkey("PizzaId");
        }

        public DBSet<Pizza> Pizzas {get; set;}
        
    }
}
