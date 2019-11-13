using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;
using Interfaces;

namespace Logics
{
    public class WorkerService : IWorkerService
    {
        IStorageContext _context;
        IRepository<Worker> _repository;
        public WorkerService(IStorageContext context)
        {
            _context = context;
            _repository = new WorkerRepository(_context);
        }

        public Worker GetWorker(int? id)
        {
            if (id == null)
            {
                //throw new ValidationException("Не установлено id телефона", "");
            }

            Worker worker = _repository.Get(id.Value);

            if (worker == null)
            {
                //throw new ValidationException("Телефон не найден", "");
            }

            return new Worker { };
        }

        public IEnumerable<Worker> GetWorkers()
        {
            return _repository.GetAll();
        }

        public void MakeWorker(Worker materialDto)
        {
            Worker worker = new Worker()
            {
                //Quantity = materialDto.Quantity
            };
            _repository.Create(worker);
        }
    }
}
