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
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>();
        public Form1()
        {
            productos = new List<Producto>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirMenuPrincipal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirMenuPrincipal();
        }

        private void AbrirMenuPrincipal()
        {
            MenuPrincipalForm menu = new MenuPrincipalForm();
            menu.Show();
        }

        private void buttonIngresoProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Codigo = textBoxCodigo.Text;
            producto.Nombre= textBoxNombre.Text;
            producto.Marca= textBoxMarca.Text;
            producto.Precio_compra = numeriPrecioCompra.Value;
            producto.Precio_venta = numericPrecioVenta.Value;
            producto.Cantidad_existente = numericCantidad.Value;

            productos.Add(producto);
            PersistenciaProducto persistencia= new PersistenciaProducto();
            persistencia.GuardarJson(productos);
        }
    }
}
