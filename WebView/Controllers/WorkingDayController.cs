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
    public class WorkingDayController : Controller
    {
        IWorkingDayService _workingDayService;
        public WorkingDayController(IWorkingDayService workingDayService)
        {
            _workingDayService = workingDayService;
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
        public IEnumerable<WorkingDayViewModel> Get()
        {
            var workingDays = _workingDayService.GetWorkingDays();

            var mapper = new MapperConfiguration(w =>
            {
                w.CreateMap<WorkingDay, WorkingDayViewModel>()
                        .ForMember("Materials", opt => opt.MapFrom(m => m.Materials))
                        .ForMember("Workers", opt => opt.MapFrom(f => f.Workers))
                        .ForMember("Services", opt => opt.MapFrom(f => f.Services))
                        .ForMember("Date", opt => opt.MapFrom(s => s.Date));
                w.CreateMap<Material, MaterialViewModel>()
                        .ForMember("Shop", opt => opt.MapFrom(s => s.Shop.Name))
                        .ForMember("Name", opt => opt.MapFrom(s => s.MaterialType.Name))
                        .ForMember("Quantity", opt => opt.MapFrom(s => s.Quantity))
                        .ForMember("Date", opt => opt.MapFrom(s => s.WorkingDay.Date));
                w.CreateMap<Worker, WorkerViewModel>()
                       .ForMember("Name", opt => opt.MapFrom(a => a.Name))
                       .ForMember("Position", opt => opt.MapFrom(a => a.Position));
                w.CreateMap<Service, ServiceViewModel>()
                       .ForMember("Name", opt => opt.MapFrom(a => a.ServiceTypes.Name))
                       .ForMember("Shop", opt => opt.MapFrom(a => a.Shop.Name))
                       .ForMember("WorkingDay", opt => opt.MapFrom(a => a.WorkingDay.Date))
                       .ForMember("Quantity", opt => opt.MapFrom(a => a.Quantity));
            }).CreateMapper();
            return mapper.Map<IEnumerable<WorkingDay>, List<WorkingDayViewModel>>(workingDays);
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
