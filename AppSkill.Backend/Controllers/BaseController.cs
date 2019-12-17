using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppSkill.Backend.Controllers
{
    public class BaseController<T1> : ControllerBase
    {
        protected readonly ILogger<T1> logger;
        

        protected void Log(LogLevel level, string message)
        {
            logger.Log(level, message);
        }


        
    }
}
