using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso_Undemy.Models
{
    public class MarcaCLS
    {
        [Display(Name = "ID")]
        public int iidmarca { get; set; }
        [Display(Name = "nombre")]
        public string nombre { get; set; }
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
        public int bhabilitado { get; set; }

    }
}