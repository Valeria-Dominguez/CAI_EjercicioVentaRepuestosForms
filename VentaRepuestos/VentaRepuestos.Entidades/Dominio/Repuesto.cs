using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Entidades.Dominio
{
    public class Repuesto
    {
        int _codigo;
        string _nombre;
        double _precio;
        int _stock;
        Categoria _categoria;

        public Repuesto(int codigo, string nombre, double precio, int stock, Categoria categoria)
        {
            _codigo = codigo;
            _nombre = nombre;
            _precio = precio;
            _stock = stock;
            _categoria = categoria;
        }

        public Repuesto()
        {
            _categoria = new Categoria();
        }

        public int Codigo { get => _codigo; }
        public string Nombre { get => _nombre; }
        public double Precio { get => _precio; set => _precio = value; }
        public Categoria Categoria { get => _categoria; }
        public int Stock { get => _stock; set => _stock = value; }

        public override string ToString()
        {
            return $"{this._codigo} {this._nombre} / Precio: ${this._precio} - Cantidad: {this._stock} - Categoria: {this._categoria.Codigo} {this._categoria.Nombre}";
        }

    }
}
