using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso_Undemy.Models
{
    public class SucursalCLS
    {
        [Display(Name = "Id")]
        public int iidsucursal { get; set; }
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Display(Name = "Direccion")]
        public string direccion { get; set; }
        [Display(Name = "Telefono")]
        public string telefono { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Fecha De Apertura")]
        public DateTime fechaapertura { get; set; }
        public int bhalitado { get; set; }
    }
}