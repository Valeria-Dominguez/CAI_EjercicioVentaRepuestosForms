using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Negocio.Excepciones
{
    public class RepuestoExistenteException: Exception
    {
        public RepuestoExistenteException(): base ("Ya existe el repuesto")
        {
        }
        public RepuestoExistenteException(string mensaje) : base()
        {
        }
    }
}
