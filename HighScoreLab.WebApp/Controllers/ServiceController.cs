using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Abstractions.Repository;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace HighScoreLab.Web.Controllers
{
    public class ServiceController : Controller
    {
        [Route("Service")]
        public IActionResult Index(IServiceRepository repository)
        {
            var service = repository.GetServices();
            return View();
        }
    }
}