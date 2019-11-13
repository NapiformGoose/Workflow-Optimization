using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsLibrary
{
    public class WorkerType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }
        public IList<Worker> Workers { get; set; }
        public WorkerType()
        {
            Workers = new List<Worker>();
        }
    }
}
