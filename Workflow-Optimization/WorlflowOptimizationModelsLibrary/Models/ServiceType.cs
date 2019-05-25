using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorlflowOptimizationModelsLibrary.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public IList<Service> Services { get; set; }
        public ServiceType()
        {
            Services = new List<Service>();
        }
    }
}
