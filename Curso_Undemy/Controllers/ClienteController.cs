using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Curso_Undemy.Models;


namespace Curso_Undemy.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> ListaCliente = null;
            using (var bd = new BDPasajeEntities())
            {
                ListaCliente = (from cliente in bd.Cliente
                                select new ClienteCLS
                                {
                                    iidcliente = cliente.IIDCLIENTE,
                                    nombre = cliente.NOMBRE,
                                    direccion = cliente.DIRECCION,
                                    telefonocelular = cliente.TELEFONOFIJO
                                }).ToList();
            }
            return View(ListaCliente);
        }
    }
}