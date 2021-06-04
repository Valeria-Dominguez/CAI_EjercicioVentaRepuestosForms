using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaRepuestos.Entidades.Dominio;
using VentaRepuestos.Negocio;

namespace VentaRepuestos.GUI
{
    public partial class FormABM : Form
    {
        RepuestoNegocio _suc;
        public FormABM(RepuestoNegocio suc)
        {
            this._suc = suc;
            InitializeComponent();
        }

        private void FormABM_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            try
            {
                lstRepuestos.DataSource = null;
                lstRepuestos.DataSource = _suc.ListaProductos;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void lstRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosRepuesto();
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            txtCod.Enabled = false;
            txtNombre.Enabled = false;
            txtCategoriaID.Enabled = false;
            txtCategoriaNombre.Enabled = false;
        }

        private void CargarDatosRepuesto()
        {
            if(lstRepuestos.DataSource!=null)
            {
                Repuesto repuestoSeleccionado = (Repuesto)lstRepuestos.SelectedItem;
                txtCod.Text = repuestoSeleccionado.Codigo.ToString();
                txtNombre.Text = repuestoSeleccionado.Nombre;
                txtPrecio.Text = repuestoSeleccionado.Precio.ToString();
                txtCategoriaID.Text = repuestoSeleccionado.Categoria.Codigo.ToString();
                txtCategoriaNombre.Text = repuestoSeleccionado.Categoria.Nombre;
                txtStock.Text = repuestoSeleccionado.Stock.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCod.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtCategoriaID.Text = String.Empty;
            txtCategoriaNombre.Text = String.Empty;
            txtStock.Text = String.Empty;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtCod.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtCategoriaID.Enabled = true;
            txtCategoriaNombre.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                int cod = int.Parse(txtCod.Text);
                string nombre = txtNombre.Text;
                double precio = double.Parse(txtPrecio.Text);
                int categoriaId = int.Parse(txtCategoriaID.Text);
                string categoriaNombre = txtCategoriaNombre.Text;
                Categoria categoria = new Categoria(categoriaId, categoriaNombre);
                Repuesto repuesto = new Repuesto(cod, nombre, precio, 0, categoria);
                _suc.AgregarRepuesto(repuesto);
                MessageBox.Show("Repuesto agregado");
                CargarLista();
                LimpiarCampos();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void Validar()
        {
            if (
                txtCod.Text == String.Empty ||
                txtNombre.Text == String.Empty ||
                txtCategoriaID.Text == String.Empty ||
                txtCategoriaNombre.Text == String.Empty
                )
                throw new Exception("Ningún campo puede estar vacío");

            if (!int.TryParse(txtCod.Text, out int cod))
                throw new Exception("Codigo: Debe ingresar un número"); 

            if (!int.TryParse(txtCategoriaID.Text, out int id))
                throw new Exception("Id Categoría: Debe ingresar un número");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarPrecio();
                Repuesto repuestoSeleccionado = (Repuesto)lstRepuestos.SelectedItem;
                double precio = double.Parse(txtPrecio.Text);
                _suc.ModificarPrecio(repuestoSeleccionado, precio);
                MessageBox.Show("Repuesto modificado");
                CargarLista();
                LimpiarCampos();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void ValidarPrecio()
        {
            if (!double.TryParse(txtCod.Text, out double precio))
                throw new Exception("Precio: Debe ingresar un número");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Repuesto repuestoSeleccionado = (Repuesto)lstRepuestos.SelectedItem;
                _suc.QuitarRepuesto(repuestoSeleccionado);
                MessageBox.Show("Repuesto eliminado");
                CargarLista();
                LimpiarCampos();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
