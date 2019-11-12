using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;
using Interfaces;

namespace Logics
{
    public class MaterialService : IMaterialService
    {
        IStorageContext _context;
        IRepository<Material> _repository;
        public MaterialService(IStorageContext context) //попробовать с зависимостями
        {
            _context = context;
            _repository = new MaterialRepository(_context);
        }

        public Material GetMaterial(int? id)
        {
            if (id == null)
            {
                //throw new ValidationException("Не установлено id телефона", "");
            }

            Material material = _repository.Get(id.Value);

            if (material == null)
            {
                //throw new ValidationException("Телефон не найден", "");
            }

            return new Material { Quantity = material.Quantity, Id = material.Id };
        }

        public IEnumerable<Material> GetMaterials()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            //var mapper = new MapperConfiguration(m => m.CreateMap<Material, MaterialDTO>()).CreateMapper();
            //return mapper.Map<IEnumerable<Material>, List<MaterialDTO>>(_repository.GetAll());
            return _repository.GetAll();
        }

        public void MakeMaterial(Material materialDto)
        {
            Material material = new Material()
            {
                Quantity = materialDto.Quantity
            };
            _repository.Create(material);
        }
    }
}
