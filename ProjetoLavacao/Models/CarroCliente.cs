using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLavacao.Models
{
    public class CarroCliente
    {
        public int Id { get; set; }

        public String Marca { get; set; }

        public String Modelo { get; set; }

        public String Cor { get; set; }

        public String Placa { get; set; }
    }
}