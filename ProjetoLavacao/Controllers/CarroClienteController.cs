using ProjetoLavacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLavacao.Controllers
{
    public class CarroClienteController : Controller
    {
        public List<CarroCliente> Customers = new List<CarroCliente>
        {
            new CarroCliente { Id = 1 , Marca = "VW", Modelo = "Gol", Cor = "Branco", Placa = "OKM-0007"  }

        };

        // GET: Cadastros
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var CarroCliente = Customers.SingleOrDefault(c => c.Id == id);


            if (CarroCliente == null)
                return HttpNotFound();

            return View(CarroCliente);
        }
    }
}