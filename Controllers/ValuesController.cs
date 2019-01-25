using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gust.Models;
using Microsoft.EntityFrameworkCore;

namespace gust.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // GET api/values
        // [HttpGet]
        // public IActionResult AllAirports()
        // {
        //     var airports = _context.Airports.ToList();
        //     return Ok(airports);
        // }
        [HttpGet]
        public IActionResult AllRunways()
        {
            var runways = _context.Runways.ToList();
            return Ok(runways);
        }

        [HttpGet("{run_id}")]
        public IActionResult OneRunwayDeg(int run_id)
        {
            var runway = _context.Runways.FirstOrDefault(x=>x.runway_id == run_id);
            // var runwaydeg = _context.Runways.Where
            Runway thisRunway = _context.Runways.FirstOrDefault(c=>c.runway_id == run_id);
            return Ok(thisRunway);
        }
        // GET api/values/5
        // [HttpGet("{airport_id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
