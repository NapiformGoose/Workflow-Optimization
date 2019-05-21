using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Workflow_Optimization.Context;
using Workflow_Optimization.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class MaterialsController : Controller
    {
        WorkflowOpimizationDBContext _context;
        public MaterialsController(WorkflowOpimizationDBContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Material> Get()
        {
            return _context.Materials.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Material material = _context.Materials.FirstOrDefault(o => o.Id == id);
            if (material == null)
                return NotFound();
            return new ObjectResult(material);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Material material)
        {
            if (material == null)
            {
                return BadRequest();
            }
            _context.Materials.Add(material);
            _context.SaveChanges();

            return Ok(material);
        }

        // PUT api/<controller>/
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Material material)
        {
            if (material == null)
            {
                return BadRequest();
            }
            if (!_context.Materials.Any(x => x.Id == material.Id))
            {
                return NotFound();
            }

            _context.Update(material);
            _context.SaveChanges();
            return Ok(material);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Material material = _context.Materials.FirstOrDefault(x => x.Id == id);
            if (material == null)
            {
                return NotFound();
            }
            _context.Materials.Remove(material);
            _context.SaveChanges();
            return Ok(material);
        }
    }
}
