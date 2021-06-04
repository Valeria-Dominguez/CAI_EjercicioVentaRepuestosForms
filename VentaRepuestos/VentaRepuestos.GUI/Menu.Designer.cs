
namespace VentaRepuestos.GUI
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnABM = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblSuc = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABM
            // 
            this.btnABM.Location = new System.Drawing.Point(65, 47);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(174, 25);
            this.btnABM.TabIndex = 0;
            this.btnABM.Text = "AByM respuestos";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(65, 78);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(174, 25);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Repuestos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblSuc
            // 
            this.lblSuc.AutoSize = true;
            this.lblSuc.Location = new System.Drawing.Point(12, 9);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(77, 13);
            this.lblSuc.TabIndex = 3;
            this.lblSuc.Text = "Datos sucursal";
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(65, 109);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(174, 25);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Modificar stock ";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 187);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.lblSuc);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnABM);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnABM;
        private System.Windows.Forms.Button btnListar;
        protected System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Button btnStock;
    }
}

