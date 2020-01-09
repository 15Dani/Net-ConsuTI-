using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEstado.Models
{
    public class Estado
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Sexo { get; set; }

        public string UF { get; set; }

        public double ValorMaximo { get; set; }

        public double ValorMinimo { get; set; }
    }
}