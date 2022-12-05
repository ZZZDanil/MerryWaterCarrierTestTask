using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ВеселыйВодовоз.Models;

namespace ВеселыйВодовоз
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Tag> Tags => Set<Tag>();
        public ApplicationContext() { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQLitePCL.Batteries.Init();
            optionsBuilder.UseSqlite("Filename=app.db");
        }
    }
}
