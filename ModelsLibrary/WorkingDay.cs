using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsLibrary
{
    public class WorkingDay
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } 
        public IList<Material> Materials { get; set; }
        public IList<Service> Services { get; set; }
        public IList<Worker> Workers { get; set; }
        public WorkingDay()
        {
            Materials = new List<Material>();
            Services = new List<Service>();
            Workers = new List<Worker>();
        }
    }
}