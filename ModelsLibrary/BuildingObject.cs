using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsLibrary
{
    public class BuildingObject
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public IList<Material> Materials { get; set; }
        public IList<Service> Services { get; set; }

        public BuildingObject()
        {
            Materials = new List<Material>();
            Services = new List<Service>();
        }
    }
}
