using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso_Undemy.Models
{
    public class ClienteCLS
    {
        public int iidcliente{ get; set; }
        [Display(Name = "")]
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefonocelular { get; set; }
    }
}