using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaRepuestos.Negocio;

namespace VentaRepuestos.GUI
{
    public partial class Menu : Form
    {
        RepuestoNegocio _suc;
        public Menu()
        {
            _suc = new RepuestoNegocio("Suc. Venta Repuestos", "Domicilio");
            InitializeComponent();
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            FormABM frmABM = new FormABM(_suc);
            frmABM.Owner = this;
            frmABM.Show();
            this.Hide();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FormListar frmListar = new FormListar(_suc);
            frmListar.Owner = this;
            frmListar.Show();
            this.Hide();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock frmStock = new FormStock(_suc);
            frmStock.Owner = this;
            frmStock.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblSuc.Text = $"{_suc.NombreComercio} - {_suc.Direccion}";
        }
    }
}
