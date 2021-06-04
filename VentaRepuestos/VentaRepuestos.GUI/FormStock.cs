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
    public partial class FormStock : Form
    {
        RepuestoNegocio _suc;
        public FormStock(RepuestoNegocio suc)
        {
            this._suc = suc;
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            CargarRepuestos();
        }

        private void CargarRepuestos()
        {
            try
            {
                cmbStock.DataSource = null;
                cmbStock.DataSource = this._suc.ListaProductos;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbStock.DataSource!=null)
                {
                    Repuesto repuestoSeleccionado = (Repuesto)cmbStock.SelectedItem;
                    Validar();
                    this._suc.AgregarStock(repuestoSeleccionado, int.Parse(txtCantidad.Text));
                    MessageBox.Show("Stock modificado");
                    CargarRepuestos();
                }
                Limpiar();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void Validar()
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
                throw new Exception("Debe ingresar un número");
        }

        private void Limpiar()
        {
            txtCantidad.Text = string.Empty;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStock.DataSource != null)
                {
                    Repuesto repuestoSeleccionado = (Repuesto)cmbStock.SelectedItem;
                    Validar();
                    this._suc.QuitarStock(repuestoSeleccionado, int.Parse(txtCantidad.Text));
                    MessageBox.Show("Stock modificado");
                    CargarRepuestos();
                }
                Limpiar();
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
