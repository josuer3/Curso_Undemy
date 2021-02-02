using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Curso_Undemy.Models; 

namespace Curso_Undemy.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            List<SucursalCLS> ListaSucursal = null;
            using (var bd = new BDPasajeEntities())
            {
                ListaSucursal = (from Sucursal in bd.Sucursal
                                 where Sucursal.BHABILITADO == 1
                                 select new SucursalCLS
                                 {
                                     iidsucursal = Sucursal.IIDSUCURSAL,
                                     nombre = Sucursal.NOMBRE,
                                     telefono = Sucursal.TELEFONO,
                                     email=Sucursal.TELEFONO
                                 }).ToList();
            }
            return View(ListaSucursal);
        }
    }
}