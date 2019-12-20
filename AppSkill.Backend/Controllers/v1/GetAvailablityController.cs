using System;
using System.Collections.Generic;
using AppSkill.Core;
using AppSkill.Model.Service;
using AppSkill.Operation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppSkill.Backend.Controllers.v1
{
    [Route("v1/[controller]")]
    public class GetAvailablityController : Controller
    {
        IAppSkillService _appSkillService;
        public GetAvailablityController(IAppSkillService appSkillService)
        {
            _appSkillService = appSkillService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get(GetAvailabityRequestModal _object)
        {
            var a = _appSkillService.GetAllLocations();
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
