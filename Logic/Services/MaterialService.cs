using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ModelsLibrary;
using Interfaces;
using Common;

namespace Logics
{
    public class MaterialService : IMaterialService
    {
        IStorageContext _context;
        IRepository<Material> _repository;
        public MaterialService(IStorageContext context) //попробовать с зависимостями
        {
            _context = context;
            _repository = new Repository<Material>(_context);
        }

        public MaterialDTO GetMaterial(int? id)
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

            return new MaterialDTO { Quantity = material.Quantity, Id = material.Id };
        }

        public IEnumerable<MaterialDTO> GetMaterials()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(m => m.CreateMap<Material, MaterialDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Material>, List<MaterialDTO>>(_repository.GetAll());
        }

        public void MakeMaterial(MaterialDTO materialDto)
        {
            Material material = new Material()
            {
                Quantity = materialDto.Quantity
            };
            _repository.Create(material);
        }
    }
}
