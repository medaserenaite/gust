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

        //------------------------------ALL AIRPORTS------------------
        //---using this, when choosing an airport
        [Route("/allairports")]
        [HttpGet]
        public IActionResult AllAirports()
        {
            var airports = _context.Airports.ToList();
            return Ok(airports);
        }

        //-------------------------------ALL RUNWAYS-----------------
        [Route("/allrunways")]
        [HttpGet]
        public IActionResult AllRunways()
        {
            var runways = _context.Runways.ToList();
            return Ok(runways);
        }

        // ---------------------------LONG AND LAT OF THE CHOSEN AIRPORT----
        [Route("/{air_id}")]
        [HttpGet]
        public IActionResult ChosenAirport(int air_id)
        {
            var chosenAirport = _context.Airports.FirstOrDefault(ca=>ca.airport_id == air_id);
            return Ok(chosenAirport);       
        }

        //uses longitude and latitude from above to connect to weather api in the front end
        //finds weather in the location
        //we pull that location's wind's angle
        //compare wind's angle to runway angles
        //-----more steps to compare all the runways?
        //when





        [HttpGet("{run_id}")]
        public IActionResult OneRunwayDeg(int run_id)
        {
            var runway = _context.Runways.FirstOrDefault(x=>x.runway_id == run_id);
            // var runwaydeg = _context.Runways.Where
            Runway thisRunway = _context.Runways.FirstOrDefault(c=>c.runway_id == run_id);
            return Ok(thisRunway.airport_ref);
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
