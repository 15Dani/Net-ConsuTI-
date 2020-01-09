using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppEstado.Models
{
     //Classe conexão com o banco
    public class EstadoContex : DbContext
    {
        public EstadoContex()
            : base("name=EstadoConnectionString")
        {
        }

        public DbSet<Estado> Estados { get; set; }
    }
}
    
