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
            this.Close();
        }
    }
}
