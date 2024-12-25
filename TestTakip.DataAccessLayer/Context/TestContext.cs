using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTakip.EntityLayer.Concrete;

namespace TestTakip.DataAccessLayer.Context
{
    public class TestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;initial " +
                "catalog=TestDb;integrated security=true");
        }

        public DbSet<Emplyoee> Emplyoees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<TestPlan> TestPlans { get; set; }
    }
}
