using System;
using System.Collections.Generic;
using System.Text;
using API;
using AutoMapper;
using ModelsLibrary;

namespace Common
{
    public class MaterialService : IMaterialService
    {
        WorkflowOpimizationDBContext _context;
        Repository<Material> _repository;
        public MaterialService(WorkflowOpimizationDBContext context)
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
