using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petclinic.Models {
    public class Contacto {
        //EL SIGNO DE INTERROGACION ES PARA DEJAR VALORES NULOS
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Question { get; set; }
    }
}