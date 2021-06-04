using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Negocio.Excepciones
{
    public class StockInsuficienteException:Exception
    {
        public StockInsuficienteException(): base ("El stock es insufuciente")
        {
        }
        public StockInsuficienteException(string mensaje) : base()
        {
        }
    }
}
