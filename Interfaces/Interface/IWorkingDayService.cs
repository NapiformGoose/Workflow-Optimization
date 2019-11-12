using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Interfaces
{
    public interface IWorkingDayService
    {
        WorkingDay GetWorkingDay(int? id);
        void MakeWorkingDay(WorkingDay materialDto);
        IEnumerable<WorkingDay> GetWorkingDays();
    }
}
