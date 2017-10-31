using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLavacao.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public int Telefone { get; set; }
    }
}