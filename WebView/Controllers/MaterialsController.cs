using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Interfaces;
using ModelsLibrary;
using AutoMapper;

namespace WebView
{
    //[Route("api/[controller]")]
    //[ApiController]
    [EnableCors("AllowAllOrigin")]
    public class MaterialsController : Controller
    {
        IMaterialService _materialService;
        public MaterialsController(IMaterialService materialService)
        {
            _materialService = materialService;
        }
        
        public ActionResult Index()
        {
            return View();
        }

        //GET: api/<controller>
        //[HttpGet]
        //public IEnumerable<MaterialDTO> Get()
        //{
        //    IEnumerable<MaterialDTO> materialDTO = _materialService.GetMaterials();
        //    return materialDTO;
        //}
        [HttpGet]
        public IEnumerable<MaterialViewModel> Get()
        {
            var mapper = new MapperConfiguration(m => m.CreateMap<Material, MaterialViewModel>()
            .ForMember("Shop", opt => opt.MapFrom(s => s.Shop.Name))
            .ForMember("Name", opt => opt.MapFrom(s => s.MaterialType.Name))
            .ForMember("Quantity", opt => opt.MapFrom(s => s.Quantity))
            .ForMember("Date", opt => opt.MapFrom(s => s.WorkingDay.Date))
            ).CreateMapper();
            return mapper.Map<IEnumerable<Material>, List<MaterialViewModel>>(_materialService.GetMaterials());
        }
        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    Material material = _context.Materials.FirstOrDefault(o => o.Id == id);
        //    if (material == null)
        //        return NotFound();
        //    return new ObjectResult(material);
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public IActionResult Post([FromBody]Material material)
        //{
        //    if (material == null)
        //    {
        //        return BadRequest();
        //    }
        //    _context.Materials.Add(material);
        //    _context.SaveChanges();

        //    return Ok(material);
        //}

        //// PUT api/<controller>/
        //[HttpPut("{id}")]
        //public IActionResult Put([FromBody]Material material)
        //{
        //    if (material == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (!_context.Materials.Any(x => x.Id == material.Id))
        //    {
        //        return NotFound();
        //    }

        //    _context.Update(material);
        //    _context.SaveChanges();
        //    return Ok(material);
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    Material material = _context.Materials.FirstOrDefault(x => x.Id == id);
        //    if (material == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Materials.Remove(material);
        //    _context.SaveChanges();
        //    return Ok(material);
        //}
    }
}
