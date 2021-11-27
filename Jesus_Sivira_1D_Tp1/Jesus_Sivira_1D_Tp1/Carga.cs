using ClassLibrary.Model.Data;
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
    public partial class frmCarga : Form
    {
        
        // Almacena la funcion Guardar
        public IContract contrato { get; set; }

        // Variable que retorna y se guarda en la queue
        public Factura carga = new Factura();

        public frmCarga()
        {
            InitializeComponent();            
        }
        
        private void frmCarga_Load(object sender, EventArgs e)
        {
            deshabilitarBoton();
        }        

        // **************        METODOS       ****************//

        void habilitarBoton()

            // Con esto verifiamos que no esten vacios los campos y asi no cargar facturas vacias en la queue
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                btnCargar.Enabled = false;
            }
            else
            {
                btnCargar.Enabled = true;
            }
        }

        void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Focus();
        }

        void deshabilitarBoton()
        {
            btnCargar.Enabled = false;
        }

        // Botones

        private void btnCargar_Click(object sender, EventArgs e)
        {
            carga.codigo = txtCodigo.Text;
            carga.descripcion = txtDescripcion.Text;
            carga.precio = txtPrecio.Text;

            contrato.Guardar(carga.codigo, carga.descripcion, carga.precio);

            limpiarCajas();
            deshabilitarBoton();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Labels y inputs

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
    

            TextBox textbox = (TextBox)sender;
            this.decimales(ref textbox, e); // Metodo para verificar decimales
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(sender, e);
        }

        private void txtPrecio_KeyUp(object sender, KeyEventArgs e)
        {
            habilitarBoton();
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            habilitarBoton();
        }

        private void txtDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            habilitarBoton();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) SendKeys.Send("{TAB}");
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) SendKeys.Send("{TAB}");
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) SendKeys.Send("{TAB}");
        }
    }
}
