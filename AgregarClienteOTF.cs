using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1programacion
{
    public partial class AgregarClienteOTF : Form
    {
        public string nit, nombre, apellido, direccion, telefono;
        public bool fill = false;

        private void AgregarClienteOTF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clienteNitOTF.Text == string.Empty ||
                clienteNombreOTF.Text == string.Empty ||
                clienteApellidoOTF.Text == string.Empty ||
                clienteDireccionOTF.Text == string.Empty ||
                clienteTelefonoOTF.Text == string.Empty)
            {
                var resultado = MessageBox.Show("Datos insuficientes. ¿Desea cancelar el registro y cancelar la venta?", "Exit", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.Cancel) e.Cancel = true;
                else fill = false;
            }
        }

        public AgregarClienteOTF()
        {
            InitializeComponent();
        }

        private void clienteAgregarOTF_Click(object sender, EventArgs e)
        {
            nit = clienteNitOTF.Text;
            nombre = clienteNombreOTF.Text;
            apellido = clienteApellidoOTF.Text;
            direccion = clienteDireccionOTF.Text;
            telefono = clienteTelefonoOTF.Text;
            fill = true;
            this.Close();
        }
    }
}
