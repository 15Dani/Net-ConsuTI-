using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppEstado.Models
{
    public class EstadoViewModel
    {
        public List<string> ListaEstados { get; set; }

        public EstadoViewModel()
        {
            ListaEstados = new List<string>();
        }
    }
}