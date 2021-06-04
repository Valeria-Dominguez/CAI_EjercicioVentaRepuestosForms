using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestos.Entidades.Dominio;

namespace VentaRepuestos.Negocio
{
    public class RepuestoNegocio
    {
        List<Repuesto> _listaProductos;
        string _nombreComercio;
        string _direccion;

        public RepuestoNegocio(string nombreComercio, string direccion)
        {
            _listaProductos = new List<Repuesto>();
            _nombreComercio = nombreComercio;
            _direccion = direccion;
        }

        public string NombreComercio { get => _nombreComercio; }
        public string Direccion { get => _direccion; }
        public List<Repuesto> ListaProductos { get => _listaProductos; }

        public void AgregarRepuesto (Repuesto repuesto)
        {
            BuscarRepuesto(repuesto.Codigo);
            this._listaProductos.Add(repuesto);                
        }

        private void BuscarRepuesto(int codigo)
        {
            foreach (Repuesto repuestoSuc in _listaProductos)
            {
                if (repuestoSuc.Codigo == codigo)
                    throw new Exception("El repuesto ya existe");
            }
        }

        public void QuitarRepuesto (Repuesto repuesto)
        {
            if (repuesto.Stock > 0)
                throw new Exception("No puede eliminarse, repuesto con stock");
            this._listaProductos.Remove(repuesto);
        }

        public void ModificarPrecio (Repuesto repuesto, double precio)
        {
            repuesto.Precio = precio;
        }
        public void AgregarStock (Repuesto repuesto, int cantidad)
        {
            repuesto.Stock = repuesto.Stock + cantidad;
        }
        public void QuitarStock(Repuesto repuesto, int cantidad)
        {
            if (repuesto.Stock < cantidad)
                throw new Exception("El stock disponible es menor a la cantidad que desea quitar:" + repuesto.Stock);
            repuesto.Stock = repuesto.Stock - cantidad;
        }
        public List<Repuesto> TraerPorCateogria(int id)
        {
            List<Repuesto> repuestosCategoria = new List<Repuesto>();
            foreach(Repuesto repuesto in this._listaProductos)
            {
                if (repuesto.Categoria.Codigo == id)
                    repuestosCategoria.Add(repuesto);
            }
            return repuestosCategoria;
        }
    }
}
