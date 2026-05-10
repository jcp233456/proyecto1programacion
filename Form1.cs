using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1programacion
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>();
        List<Cliente> clientes= new List<Cliente>();
        List<Factura> facturas = new List<Factura>();
        public Form1()
        {
            InitializeComponent();
            CargarProductos();
            CargarClientes();
            CargarFacturas();
            CargarReportes();
            AdminMenu.Hide();
            returnBtn.Hide();
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

            actualizarComboBoxCliente();
            actualizarComboBoxProducto();
        }

        private void buttonIngresoProducto_Click(object sender, EventArgs e)
        {
            if (!productos.Exists(prod => prod.Codigo.Equals(textBoxCodigo.Text)))
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
            else MessageBox.Show("El código del producto ya existe, confirme si se ingreso el código correctamente", "Producto Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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





        //REPORTES
        private void CargaReportes()
        {
           Reportes_MasVendidos();
        }
        private void Reportes_MasVendidos()
        {

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
            if (!clientes.Exists(client => client.Nit.Equals(textBoxNit.Text)))
            {
                Cliente cliente = new Cliente();
                cliente.Nit = textBoxNit.Text;
                cliente.Nombre = textBoxNombreCliente.Text;
                cliente.Apellido = textBoxApellidoCliente.Text;
                cliente.Direccion = textBoxDireccionCliente.Text;
                cliente.Telefono = textBoxTelefonoCliente.Text;
                clientes.Add(cliente);
                PersistenciaCliente persistencia = new PersistenciaCliente();
                persistencia.GuardarJson(clientes);
                actualizarComboBoxCliente();
                actualizarComboBoxProducto();
                MessageBox.Show("Cliente ingresado correctamente.");
            }
            else MessageBox.Show("El NIT del cliente ya existe en el sistema, confirme si se ingreso correctamente", "Cliente ya existe en el sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void guardarDatosDeVenta(string clienteNit ,Producto productoSeleccionado, decimal cantidadVendida) {
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

            //Guardar Venta Para reportes
            Reportes_Productos_Mas_vendidos();
        }


        //REPORTES *-------------------------------------------------------------------------------------------*

        private void CargarReportes()
        {
            Reportes_Productos_Mas_vendidos();
            Reportes_Productos_Pendientes_de_entrega();
        }

        private void Reportes_Productos_Mas_vendidos()
        {
            List<Reportes_MasVendidos>Lista_masvendidos = new List<Reportes_MasVendidos>();

            for (int i = 0; i < facturas.Count; i++)
            {
                bool existe = false;

                for (int j = 0; j < Lista_masvendidos.Count; j++)
                {
                    if (facturas[i].Nombreproducto == Lista_masvendidos[j].Nombre)
                    {
                        Lista_masvendidos[j].CantidadVendida += decimal.Parse(facturas[i].Cantidadproducto);
                        existe = true;
                    }
                }

                if (existe == false)
                {
                    Reportes_MasVendidos nuevo = new Reportes_MasVendidos();

                    nuevo.Nombre = facturas[i].Nombreproducto;
                    nuevo.CantidadVendida = decimal.Parse(facturas[i].Cantidadproducto);

                    Lista_masvendidos.Add(nuevo);
                }

                Lista_masvendidos.Sort((a,b) => b.CantidadVendida.CompareTo(a.CantidadVendida));

                Actualizacion_Grid_reportes(Lista_masvendidos);
            }
        }

        

        private void Actualizacion_Grid_reportes(List<Reportes_MasVendidos> top)
        {
           
            if (top.Count == 0)
            {
                label_reportes_ALERTA_PRODUCTOS_MASVENDIDOS.Text = "NO HAY PRODUCTOS A MOSTRAR";
            }
            else
            {
                DataGrid_Reportes_MasVendidos.Visible = true;
                DataGrid_Reportes_MasVendidos.DataSource = null;
                DataGrid_Reportes_MasVendidos.DataSource = top;

            }
            
        }

        private void button_Reportes_VentasEntreFechas_Click(object sender, EventArgs e)
        {
            DateTime Fecha_Inicio = DatePicker_Reportes_Ventas_Inicio.Value.Date;
            DateTime Fecha_Final = DatePicker_Reportes_Ventas_FINAL.Value.Date;

            int cant_ventas = 0;
            int productos_vendidos = 0;

            foreach (var item in facturas)
            {
                DateTime fecha_factura = item.Fechaventa.Date;

                if ((fecha_factura >= Fecha_Inicio) && (fecha_factura <= Fecha_Final))
                {
                    cant_ventas++;
                    productos_vendidos += Int32.Parse(item.Cantidadproducto);
                }
            }

            label_Reportes_VentasEntreFechas_1.Text = "CANTIDAD DE VENTAS REALIZADAS";
            label_Reportes_VentasEntreFechas_2.Text = "\n" + cant_ventas;
            label_Reportes_VentasEntreFechas_3.Text = "CANTIDAD DE PRODUCTOS VENDIDOS";
            label_Reportes_VentasEntreFechas_4.Text = "\n" + productos_vendidos;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime Fecha_inicio = datepicker_reportes_ganancias_inicio.Value.Date;
            DateTime Fecha_Final = datepicker_reportes_ganancias_final.Value.Date;

            decimal gananciatotal = 0;

            foreach (var itemproducto in productos)
            {
                
                foreach (var itemfactura in facturas)
                {
                    decimal gananciadelproducto = 0;
                    int cantidad_de_producto_vendido = 0;
                    if ((itemproducto.Codigo == itemfactura.Codigoproducto) && (itemfactura.Fechaventa.Date>=Fecha_inicio) && (itemfactura.Fechaventa.Date<=Fecha_Final)) 
                    {
                        gananciadelproducto = itemproducto.Precio_venta - itemproducto.Precio_compra;
                        cantidad_de_producto_vendido = Int16.Parse(itemfactura.Cantidadproducto);

                        gananciatotal += (gananciadelproducto * cantidad_de_producto_vendido);
                    }

                }
                

            }


            //mostrar ganancia

            Label_reporte_ganancia_1.Text = "GANANCIAS TOTALES:";
            Label_reporte_ganancia_2.Text = "\n" + gananciatotal;




        }

        private void Reportes_Productos_Pendientes_de_entrega()
        {
            List<Reportes_Producto_Por_entregar> lista_producto_entrega = new List<Reportes_Producto_Por_entregar>() ;
            foreach (var item in facturas)
            {
                if (item.Estadoentrega == false)
                {
                    Reportes_Producto_Por_entregar nuevo = new Reportes_Producto_Por_entregar();
                    nuevo.Nitcliente = item.Nitcliente;
                    nuevo.Codigo_producto = item.Codigoproducto;
                    nuevo.Nombre_producto = item.Nombreproducto;
                    nuevo.Estado_producto = item.Estadoentrega;

                    lista_producto_entrega.Add(nuevo);
                }
            }
            datagrid_reportes_ventas_pendientes.DataSource = null;
            if (lista_producto_entrega.Count==0)
            {
                label_reportes_ALERTA_ventas_pendientes.Text = "NO HAY PRODUCTOS POR ENTREGAR";
            } else
            {
                datagrid_reportes_ventas_pendientes.Visible = true;
                datagrid_reportes_ventas_pendientes.DataSource = lista_producto_entrega;

            }



        }


        private void label_Reportes_VentasEntreFechas_3_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adminMenuBtn_Click(object sender, EventArgs e)
        {
            AdminMenu.Show();
            returnBtn.Show();
            clientMenuBtn.Hide();
            adminMenuBtn.Hide();
            adminLabel.Hide();
            clientLabel.Hide();
        }

        private void clientMenuBtn_Click(object sender, EventArgs e)
        {
            MenuClientes mClietnes = new MenuClientes(clientes, productos, facturas);
            mClietnes.Show();
            this.Hide();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            AdminMenu.Hide();
            returnBtn.Hide();
            clientMenuBtn.Show();
            adminMenuBtn.Show();
            adminLabel.Show();
            clientLabel.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
