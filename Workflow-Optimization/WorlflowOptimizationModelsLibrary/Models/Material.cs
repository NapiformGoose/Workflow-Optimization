using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workflow_Optimization.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; } //количество
    }
}