using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppSkill.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetAvailability : BaseController<GetAvailability>
    {
        public GetAvailability()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
