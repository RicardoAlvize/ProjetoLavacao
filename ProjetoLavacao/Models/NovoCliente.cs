using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLavacao.Models
{
    public class NovoCliente
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public int Cpf { get; set; }

        public String Endereco { get; set; }

        public int Telefone { get; set; }
    }
}