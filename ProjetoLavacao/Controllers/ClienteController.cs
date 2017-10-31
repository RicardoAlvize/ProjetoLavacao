using ProjetoLavacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLavacao.Controllers
{
    public class ClienteController : Controller
    {
        public List<Cliente> Customers = new List<Cliente>
        {
            new Cliente {Id = 1,Nome = "Ricardo",Sobrenome = "Alvize",Telefone = 92119535},
            new Cliente {Id = 2,Nome = "Fulano",Sobrenome = "jubis",Telefone = 8896572},
            new Cliente {Id = 3,Nome = "sicrano",Sobrenome = "Jubileiu",Telefone = 98554989},
        };

        // GET: Cadastros
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var Cliente = Customers.SingleOrDefault(c => c.Id == id);


            if (Cliente == null)
                return HttpNotFound();

            return View(Cliente);
        }
    }
}