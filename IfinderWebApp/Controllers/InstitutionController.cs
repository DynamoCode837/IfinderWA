using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IfinderWebApp.Controllers
{
    public class InstitutionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}