using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace petclinic.Models {
    [Table("t_contacto")]
    public class Contacto {
        //EL SIGNO DE INTERROGACION ES PARA DEJAR VALORES NULOS
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

        [Column("Phone")]
        public string? Phone { get; set; }

        [Column("Question")]
        public string? Question { get; set; }
    }
}