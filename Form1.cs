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
        List<Cliente>clientes= new List<Cliente>();
        List<Factura> facturas = new List<Factura>();
        public Form1()
        {
            InitializeComponent();
            CargarProductos();
            CargarClientes();
            CargarFacturas();

        }

        private void CargarProductos()
        {
            PersistenciaProducto persistencia = new PersistenciaProducto();
            productos = persistencia.leerJson();
            ActualizarComboBox();
        }
        private void CargarClientes()
        {
            PersistenciaCliente persistencia = new PersistenciaCliente();
            clientes = persistencia.leerJson();
            actualizarComboBoxCliente();

        }
        private void CargarFacturas()
        {
            PersistenciaFactura persistencia = new PersistenciaFactura();
            facturas = persistencia.leerJson();
            actualizarComboBoxCliente();
            actualizarComboBoxProducto();

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
            producto.Nombre = textBoxNombreProducto.Text;
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

        private void buttonIngresoCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente= new Cliente();
            cliente.Nit=textBoxNit.Text;
            cliente.Nombre=textBoxNombreCliente.Text;
            cliente.Apellido = textBoxApellidoCliente.Text;
            cliente.Direccion = textBoxDireccionCliente.Text;
            cliente.Telefono = textBoxTelefonoCliente.Text;
            clientes.Add(cliente);
            PersistenciaCliente persistencia = new PersistenciaCliente();
            persistencia.GuardarJson(clientes);
            actualizarComboBoxCliente();
            MessageBox.Show("Cliente ingresado correctamente.");

        }

        private void actualizarComboBoxCliente()
        {
            comboBoxVentaNit.DataSource = null;
            comboBoxVentaNit.DataSource = clientes;
            comboBoxVentaNit.DisplayMember = "Nit";
            comboBoxVentaNit.ValueMember = "Nit";

        }
        private void actualizarComboBoxProducto()
        {
            comboBoxVentaProducto.DataSource = null;
            comboBoxVentaProducto.DataSource = productos;
            comboBoxVentaProducto.DisplayMember = "Nombre";
            comboBoxVentaProducto.ValueMember = "Codigo";

        }

        private void buttonVenta_Click(object sender, EventArgs e)
        {
            decimal cantidadVendida = 0;
            if (!decimal.TryParse(textBoxVentaCantidad.Text, out cantidadVendida))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                return;
            }

            Producto productoSeleccionado = productos.FirstOrDefault(p => p.Codigo == comboBoxVentaProducto.SelectedValue.ToString());
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            if (productoSeleccionado.Cantidad_existente < cantidadVendida)
            {
                MessageBox.Show("No hay suficiente stock disponible. Stock actual: " + productoSeleccionado.Cantidad_existente);
                return;
            }

            Factura factura = new Factura();
            factura.Numfactura = facturas.Count + 1;
            factura.Fechaventa = DateTime.Now;
            factura.Nitcliente = comboBoxVentaNit.Text;
            factura.Cantidadproducto = textBoxVentaCantidad.Text;
            factura.Codigoproducto = productoSeleccionado.Codigo;
            factura.Nombreproducto = productoSeleccionado.Nombre;
            bool estadoEntrega;

            if (checkBoxEntregado.Checked == checkBoxNoEntregado.Checked)
            {
                MessageBox.Show("Selecciona solo una opción (Entregado o No entregado)");
                return;
            }

            if (checkBoxEntregado.Checked)
            {
                estadoEntrega = true;
            }
            else
            {
                estadoEntrega = false;
            }

            factura.Estadoentrega = estadoEntrega;
            facturas.Add(factura);

            // Descontar del stock
            productoSeleccionado.Cantidad_existente -= cantidadVendida;

            // Guardar cambios en facturas y productos
            PersistenciaFactura persistenciaF = new PersistenciaFactura();
            persistenciaF.GuardarJson(facturas);

            PersistenciaProducto persistenciaP = new PersistenciaProducto();
            persistenciaP.GuardarJson(productos);

            // Actualizar UI
            actualizarComboBoxProducto();
            ActualizarComboBox();

            MessageBox.Show("Factura registrada y stock actualizado correctamente.");
        }
    }
}
