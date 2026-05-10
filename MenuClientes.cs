using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto1programacion
{
    public partial class MenuClientes : Form
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Producto> productos = new List<Producto>();
        public List<Factura> facturas = new List<Factura>();
        public MenuClientes(List<Cliente> clnts, List<Producto> prdcts, List<Factura> fctrs)
        {
            InitializeComponent();
            this.clientes = clnts;
            this.productos = prdcts;
            this.facturas = fctrs;
            ActualizarComboBox();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
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

            //Función de agregar clientes inexistentes "On the fly"
            if (comboBoxVentaNit.SelectedValue == null)
            {
                DialogResult resultado = MessageBox.Show("El cliente no existe. Desea agregar al nuevo cliente y continuar con la venta?",
                    "Cliente Inexistente en el sistema",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                switch (resultado)
                {
                    case DialogResult.Yes:
                        AgregarClienteOTF acotf = new AgregarClienteOTF();
                        acotf.ShowDialog();

                        string clienteNit = acotf.nit;
                        string clienteNombre = acotf.nombre;
                        string clienteApellido = acotf.apellido;
                        string clienteDireccion = acotf.direccion;
                        string clienteTelefono = acotf.telefono;

                        Cliente cliente = new Cliente();
                        cliente.Nit = clienteNit;
                        cliente.Nombre = clienteNombre;
                        cliente.Apellido = clienteApellido;
                        cliente.Direccion = clienteDireccion;
                        cliente.Telefono = clienteTelefono;
                        clientes.Add(cliente);
                        PersistenciaCliente persistencia = new PersistenciaCliente();
                        persistencia.GuardarJson(clientes);
                        actualizarComboBoxCliente();
                        actualizarComboBoxProducto();
                        MessageBox.Show("Cliente ingresado correctamente.");

                        guardarDatosDeVenta(cliente.Nit, productoSeleccionado, cantidadVendida);
                        break;
                    case DialogResult.No:
                        DialogResult resultado2 = MessageBox.Show("¿Desea guardar el nit como \"Consumidor Final\"?", "C/F", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado2 != DialogResult.Yes) return;
                        else
                        {
                            guardarDatosDeVenta(clientes.FirstOrDefault(c => c.Nombre.Equals("C/F")).Nit, productoSeleccionado, cantidadVendida);
                        }
                        break;
                    default:
                        MessageBox.Show("La venta se ha cancelado");
                        break;
                }
            }
            else guardarDatosDeVenta(comboBoxVentaNit.SelectedValue.ToString(), productoSeleccionado, cantidadVendida);
        }

        private void guardarDatosDeVenta(string clienteNit, Producto productoSeleccionado, decimal cantidadVendida)
        {
            Factura factura = new Factura();
            factura.Numfactura = facturas.Count + 1;
            factura.Fechaventa = DateTime.Now;
            factura.Nitcliente = clienteNit;
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


        private void ActualizarComboBox()
        {
            actualizarComboBoxCliente();
            actualizarComboBoxProducto();
        }
    }
}
