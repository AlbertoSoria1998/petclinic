using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using petclinic.Models;

namespace petclinic.Controllers{
    public class ContactoController : Controller {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger){
            _logger = logger;
        }

        public IActionResult Index(){return View();}

        [HttpPost]
        public IActionResult Create(Contacto objContacto){
            ViewData["Message"] = "Estimado " + objContacto.Name + ", te estaremos contactando pronto";
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View("Error!");
        }
    }
}