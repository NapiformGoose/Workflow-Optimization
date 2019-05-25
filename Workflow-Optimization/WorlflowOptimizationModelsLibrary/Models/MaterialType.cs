using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorlflowOptimizationModelsLibrary.Models
{
    public class MaterialType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public IList<Material> Materials { get; set; }
        public MaterialType()
        {
            Materials = new List<Material>();
        }
    }
}
