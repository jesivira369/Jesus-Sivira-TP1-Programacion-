using ClassLibrary.Model.Data;
using ClassLibrary.Model.Tads;
using ClassLibrary.Model.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jesus_Sivira_1D_Tp1
{
    public partial class frmBuscar : Form
    {
        public IContract contrato { get; set; }

        public frmBuscar()
        {
            InitializeComponent();
        }

           //Verifica que el texto tenga algo para habilitar el boton
        void habilitarBoton()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(sender, e);
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            habilitarBoton();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
        }


        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            contrato.Buscar(txtCodigo.Text);
            txtCodigo.Text = "";
        }
    }
}
