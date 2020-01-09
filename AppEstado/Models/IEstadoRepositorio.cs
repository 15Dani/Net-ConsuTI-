using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstado.Models
{
   public interface IEstadoRepositorio 
    {
        IEnumerable<Estado> GetEstado();
        Estado GetEstadoPorID(int estadoId);
        

    }
}
