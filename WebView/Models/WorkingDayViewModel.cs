using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelsLibrary;

namespace WebView
{
    public class WorkingDayViewModel
    {
        public DateTime Date { get; set; }
        public IList<MaterialViewModel> Materials { get; set; }
        public IList<ServiceViewModel> Services { get; set; }
        public IList<WorkerViewModel> Workers { get; set; }

    }
}