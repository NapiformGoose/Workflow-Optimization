using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLibrary;

namespace API
{
    public class WorkflowOpimizationDBContext : DbContext
    {
        public WorkflowOpimizationDBContext(DbContextOptions<WorkflowOpimizationDBContext> options) : base (options)
        {
        }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkingDay> WorkingDays { get; set; }
        public DbSet<BuildingObject> BuildingObjects { get; set; }
    }
}
