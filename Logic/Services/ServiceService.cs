using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;
using Interfaces;

namespace Logics
{
    public class ServiceService : IServiceService
    {
        IStorageContext _context;
        IRepository<Service> _repository;
        public ServiceService(IStorageContext context)
        {
            _context = context;
            _repository = new ServiceRepository(_context);
        }

        public Service GetService(int? id)
        {
            //if (id == null)
            //{
            //    //throw new ValidationException("Не установлено id телефона", "");
            //}

            //Shop material = _repository.Get(id.Value);

            //if (material == null)
            //{
            //    //throw new ValidationException("Телефон не найден", "");
            //}

            return null;//new Shop { Quantity = material.Quantity, Id = material.Id };
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _repository.GetAll();
        }

        public void MakeService(Service materialDto)
        {
            //Shop material = new Shop()
            //{
            //    Quantity = materialDto.Quantity
            //};
            //_repository.Create(material);
        }
    }
}
