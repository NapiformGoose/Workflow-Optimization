using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Interfaces
{
    public interface IServiceService
    {
        Service GetService(int? id);
        void MakeService(Service materialDto);
        IEnumerable<Service> GetAllServices();
    }
}
