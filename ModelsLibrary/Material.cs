﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelsLibrary
{
    public class Material
    {
        public int Id { get; set; }

        public int MaterialTypeId { get; set; }
        public MaterialType MaterialType { get; set; }

        [Required]
        [StringLength(10)]
        public int Quantity { get; set; } 

        public int? ShopId { get; set; }
        public Shop Shop { get; set; }

        public int? WorkingDayId { get; set; }
        public WorkingDay WorkingDay { get; set; }
    }
}