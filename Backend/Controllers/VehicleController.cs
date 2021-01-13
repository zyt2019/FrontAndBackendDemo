using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        [HttpGet]
        public string GetTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss");
        }
    }
}