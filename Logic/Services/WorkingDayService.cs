using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;
using Interfaces;

namespace Logics
{
    public class WorkingDayService : IWorkingDayService
    {
        IStorageContext _context;
        IRepository<WorkingDay> _repository;
        public WorkingDayService(IStorageContext context)
        {
            _context = context;
            _repository = new WorkingDayRepository(_context);
        }

        public WorkingDay GetWorkingDay(int? id)
        {
            if (id == null)
            {
                //throw new ValidationException("Не установлено id телефона", "");
            }

            WorkingDay workingDay = _repository.Get(id.Value);

            if (workingDay == null)
            {
                //throw new ValidationException("Телефон не найден", "");
            }

            return new WorkingDay { };
        }

        public IEnumerable<WorkingDay> GetWorkingDays()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            //var mapper = new MapperConfiguration(m => m.CreateMap<Material, MaterialDTO>()).CreateMapper();
            //return mapper.Map<IEnumerable<Material>, List<MaterialDTO>>(_repository.GetAll());
            return _repository.GetAll();
        }

        public void MakeWorkingDay(WorkingDay materialDto)
        {
            WorkingDay workingDay = new WorkingDay()
            {
                //Quantity = materialDto.Quantity
            };
            _repository.Create(workingDay);
        }
    }
}
