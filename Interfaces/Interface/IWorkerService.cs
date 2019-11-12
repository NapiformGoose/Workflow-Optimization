using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Interfaces
{
    public interface IWorkerService
    {
        Worker GetWorker(int? id);
        void MakeWorker(Worker materialDto);
        IEnumerable<Worker> GetWorkers();
    }
}
