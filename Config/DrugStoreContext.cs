using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Config
{
    public class DrugStoreContext : DbContext
    {
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {
        optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=drug_store;Integrated Security=True;Trust Server Certificate=True");
    }
    }

}
