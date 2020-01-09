using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AppEstado.Models
{
    public class EstadoRepositorio : IEstadoRepositorio
    {
        
        private EstadoContex _context;

       
        public EstadoRepositorio(EstadoContex estadoContex)
        {
            this._context = estadoContex;
        }
      
        public IEnumerable<Estado> GetEstado()
        {
            return _context.Estados.ToList();
        }

  
        public Estado GetEstadoPorID(int id)
        {
            return _context.Estados.Find(id);
        }

     
    }
 }
