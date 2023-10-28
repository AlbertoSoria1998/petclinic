using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using petclinic.Models;
using petclinic.Data;

namespace petclinic.Controllers.UI
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;

        private readonly IMyEmailSender _emailSender;
        public ContactoController(ILogger<ContactoController> logger,
        ApplicationDbContext context, IMyEmailSender emailSender)
        {
            _logger = logger;
            _context = context;

            _emailSender = emailSender;
        }

        public IActionResult Index() { return View(); }

        [HttpPost]
         public async Task<IActionResult> Create(Contacto objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();

            ViewData["Message"] = "Estimado " + objContacto.Name + ", te estaremos contactando pronto";

            var message1 = $@"
            Estimado(a) {objContacto.Name},

            ¡Gracias por ponerte en contacto con nosotros!

            Hemos recibido tu solicitud y uno de nuestros representantes se pondrá en contacto contigo a la brevedad. 
            Valoramos tu interés y nos esforzamos por responder todas las consultas lo más rápido posible.

            Tu mensaje fue:
            {objContacto.Question}

            Tu Número Telefónico fue: {objContacto.Phone}
            Tu Correo electronico fue: {objContacto.Email}

            Mientras tanto, te invitamos a explorar nuestro sitio web o nuestras redes sociales para obtener más información sobre nuestros productos y servicios.

            ¡Gracias por elegirnos!

            Saludos cordiales,

            [La Empresa de Jesus xdxd]
        ";

            //await _emailSender.SendEmailAsync(objContacto.Email, "Gracias por contactarnos", message);
            await _emailSender.SendEmailAsync(objContacto.Email, "Gracias por contactarnos", message1);
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() { return View("Error!"); }
    }
}