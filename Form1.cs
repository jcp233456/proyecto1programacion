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
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            PersistenciaProducto persistencia = new PersistenciaProducto();
            productos = persistencia.leerJson();
            ActualizarComboBox();
        }

        private void ActualizarComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = productos;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Codigo";
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
            producto.Nombre = textBoxNombre.Text;
            producto.Marca = textBoxMarca.Text;
            producto.Precio_compra = numeriPrecioCompra.Value;
            producto.Precio_venta = numericPrecioVenta.Value;
            producto.Cantidad_existente = numericCantidad.Value;

            productos.Add(producto);
            PersistenciaProducto persistencia = new PersistenciaProducto();
            persistencia.GuardarJson(productos);
            ActualizarComboBox();
            MessageBox.Show("Producto ingresado correctamente.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)comboBox1.SelectedItem;
            if (seleccionado != null)
            {
                numericCambioPrecioVenta.Value = seleccionado.Precio_venta;
                numericCambioExistencia.Value = seleccionado.Cantidad_existente;
                numericCmbioPrecioCompra.Value = seleccionado.Precio_compra;
            }
        }

        private void buttonCambiarProducto_Click(object sender, EventArgs e)
        {
            Producto seleccionado = (Producto)comboBox1.SelectedItem;

            if (seleccionado != null)
            {
                seleccionado.Precio_venta = numericCambioPrecioVenta.Value;
                seleccionado.Cantidad_existente = numericCambioExistencia.Value;
                seleccionado.Precio_compra = numericCmbioPrecioCompra.Value;

                PersistenciaProducto persistencia = new PersistenciaProducto();
                persistencia.GuardarJson(productos);

                MessageBox.Show("Producto actualizado correctamente.");
                ActualizarComboBox();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
