using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workflow_Optimization.Models;

namespace Workflow_Optimization.Context
{
    public class WorkflowOpimizationsDBContext : DbContext
    {
        public WorkflowOpimizationsDBContext(DbContextOptions<WorkflowOpimizationsDBContext> options) : base (options)
        {

        }
        DbSet<Material> Materials { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<Worker> Workers { get; set; }
        DbSet<WorkingDay> WorkingDays { get; set; }
    }
}
