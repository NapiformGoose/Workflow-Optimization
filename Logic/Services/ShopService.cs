using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;
using Interfaces;

namespace Logics
{
    public class ShopService : IShopService
    {
        IStorageContext _context;
        IRepository<Shop> _repository;
        public ShopService(IStorageContext context) //попробовать с зависимостями
        {
            _context = context;
            _repository = new ShopRepository(_context);
        }

        public Shop GetShop(int? id)
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

        public IEnumerable<Shop> GetAllShop()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            //var mapper = new MapperConfiguration(m => m.CreateMap<Material, MaterialDTO>()).CreateMapper();
            //return mapper.Map<IEnumerable<Material>, List<MaterialDTO>>(_repository.GetAll());
            return _repository.GetAll();
        }

        public void MakeShop(Shop materialDto)
        {
            //Shop material = new Shop()
            //{
            //    Quantity = materialDto.Quantity
            //};
            //_repository.Create(material);
        }
    }
}
