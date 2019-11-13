using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelsLibrary
{
    public class Worker
    {
        public int Id { get; set; }

        [Required]
        public int WorkerTypeId { get; set; }
        public WorkerType WorkerTypes { get; set; }
        public int WorkingDayId { get; set; }
        public WorkingDay WorkingDay { get; set; }

    }
}