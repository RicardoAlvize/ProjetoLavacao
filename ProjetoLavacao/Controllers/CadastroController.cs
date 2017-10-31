using ProjetoLavacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoLavacao.Controllers
{
    public class CadastroController : Controller
    {
        public List<Cadastro> Customers = new List<Cadastro>
        {

            new Cadastro {Id = 1 , Nome = "Ricardo", Sobrenome = "Alvize", Cpf = 92119535, Endereco = "Rua Carlos Zemke",Telefone = 32736161 }

        };

        // GET: Cadastros
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var Cadastro = Customers.SingleOrDefault(c => c.Id == id);


            if (Cadastro == null)
                return HttpNotFound();

            return View(Cadastro);
        }
    }
}
