using System;
using AppSkill.Core;
using AppSkill.Model.Database;
using AppSkill.Operation.Operation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppSkill.Backend.Controllers.v1
{
    [Route("v1/api/[controller]")]
    public class LocationController : Controller
    {
        IUnitOfWork _ueof;
        public LocationController(IUnitOfWork unitOfWork)
        {
            _ueof = unitOfWork;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            LocationOperation op = new LocationOperation();

            op.AddLocation(_ueof,new Location() { LocationName = "Amed", CreatedDate = DateTime.Now });
            _ueof.SaveChanges();
            var a = op.GetAllLocations(_ueof);
            return Ok(a);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
