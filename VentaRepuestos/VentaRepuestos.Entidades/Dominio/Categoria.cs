using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Entidades.Dominio
{
    public class Categoria
    {
        int _codigo;
        string _nombre;

        public Categoria()
        {
        }

        public Categoria(int codigo, string nombre)
        {
            _codigo = codigo;
            _nombre = nombre;
        }

        public int Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }
    }
}
