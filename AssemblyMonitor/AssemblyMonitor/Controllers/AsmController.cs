using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssemblyMonitor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyMonitor.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AsmController : Controller
    {
        

        public string GetAllRegisterProfiles()
        {
            

            return "Test";
        }
    }
}