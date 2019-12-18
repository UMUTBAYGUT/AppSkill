using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppSkill.Backend.Controllers.v1
{
    [ApiController]
    [Route("[controller]")]
    public class GetAvailabilityController : BaseController<GetAvailabilityController>
    {
        public GetAvailabilityController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
