using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelsLibrary
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceTypes { get; set; }

        [Required]
        [StringLength(10)]
        public int Quantity { get; set; }

        public int? BuildingObjectId { get; set; }
        public BuildingObject BuildingObject { get; set; }

        public int? WorkingDayId { get; set; }
        public WorkingDay WorkingDay { get; set; }
    }
}