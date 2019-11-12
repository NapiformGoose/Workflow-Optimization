using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLibrary;
using Interfaces;

namespace Storage
{
    public class WorkflowOpimizationDBContext : DbContext, IStorageContext
    {
        public WorkflowOpimizationDBContext(DbContextOptions<WorkflowOpimizationDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0NDBMIJ\\SQLEXPRESS;Initial Catalog=WorkflowOptimizationDB;Integrated Security=True");
        }
        public DbContext Instance => this;

        public DbSet<Material> Materials { get; set; }
        //public DbSet<Service> Services { get; set; }
        //public DbSet<Worker> Workers { get; set; }
        //public DbSet<WorkingDay> WorkingDays { get; set; }
        //public DbSet<BuildingObject> BuildingObjects { get; set; }

    }
}
