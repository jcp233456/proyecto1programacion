namespace proyecto1programacion
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AGREGAR_NUEVO_PRODUCTO = new System.Windows.Forms.TabPage();
            this.buttonIngresoProducto = new System.Windows.Forms.Button();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.numericPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.numeriPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EDITAR_PRODUCTO = new System.Windows.Forms.TabPage();
            this.numericCmbioPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonCambiarProducto = new System.Windows.Forms.Button();
            this.numericCambioExistencia = new System.Windows.Forms.NumericUpDown();
            this.numericCambioPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.REPORTES = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.Mas_Vendidos = new System.Windows.Forms.TabPage();
            this.Total_Entre_Fechas = new System.Windows.Forms.TabPage();
            this.Ganancias_entre_fechas = new System.Windows.Forms.TabPage();
            this.Ventas_Pendientes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.datagrid_Reportes_Mas_vendidos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.AGREGAR_NUEVO_PRODUCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriPrecioCompra)).BeginInit();
            this.EDITAR_PRODUCTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCmbioPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCambioExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCambioPrecioVenta)).BeginInit();
            this.REPORTES.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.Mas_Vendidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Reportes_Mas_vendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1107, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1099, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.AGREGAR_NUEVO_PRODUCTO);
            this.tabControl2.Controls.Add(this.EDITAR_PRODUCTO);
            this.tabControl2.Controls.Add(this.REPORTES);
            this.tabControl2.Location = new System.Drawing.Point(6, 17);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1087, 448);
            this.tabControl2.TabIndex = 0;
            // 
            // AGREGAR_NUEVO_PRODUCTO
            // 
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.buttonIngresoProducto);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.numericCantidad);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.numericPrecioVenta);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.numeriPrecioCompra);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.textBoxMarca);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.textBoxNombre);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.textBoxCodigo);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.label6);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.label5);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.label4);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.label3);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.label2);
            this.AGREGAR_NUEVO_PRODUCTO.Controls.Add(this.label1);
            this.AGREGAR_NUEVO_PRODUCTO.Location = new System.Drawing.Point(4, 25);
            this.AGREGAR_NUEVO_PRODUCTO.Name = "AGREGAR_NUEVO_PRODUCTO";
            this.AGREGAR_NUEVO_PRODUCTO.Padding = new System.Windows.Forms.Padding(3);
            this.AGREGAR_NUEVO_PRODUCTO.Size = new System.Drawing.Size(1079, 419);
            this.AGREGAR_NUEVO_PRODUCTO.TabIndex = 0;
            this.AGREGAR_NUEVO_PRODUCTO.Text = "Agregar Productos";
            this.AGREGAR_NUEVO_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // buttonIngresoProducto
            // 
            this.buttonIngresoProducto.Location = new System.Drawing.Point(606, 151);
            this.buttonIngresoProducto.Name = "buttonIngresoProducto";
            this.buttonIngresoProducto.Size = new System.Drawing.Size(241, 63);
            this.buttonIngresoProducto.TabIndex = 12;
            this.buttonIngresoProducto.Text = "Ingresar Producto";
            this.buttonIngresoProducto.UseVisualStyleBackColor = true;
            this.buttonIngresoProducto.Click += new System.EventHandler(this.buttonIngresoProducto_Click);
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(261, 318);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(147, 22);
            this.numericCantidad.TabIndex = 11;
            // 
            // numericPrecioVenta
            // 
            this.numericPrecioVenta.DecimalPlaces = 2;
            this.numericPrecioVenta.Location = new System.Drawing.Point(261, 255);
            this.numericPrecioVenta.Name = "numericPrecioVenta";
            this.numericPrecioVenta.Size = new System.Drawing.Size(147, 22);
            this.numericPrecioVenta.TabIndex = 10;
            // 
            // numeriPrecioCompra
            // 
            this.numeriPrecioCompra.DecimalPlaces = 2;
            this.numeriPrecioCompra.Location = new System.Drawing.Point(261, 196);
            this.numeriPrecioCompra.Name = "numeriPrecioCompra";
            this.numeriPrecioCompra.Size = new System.Drawing.Size(147, 22);
            this.numeriPrecioCompra.TabIndex = 9;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(266, 135);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(142, 22);
            this.textBoxMarca.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(266, 80);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(142, 22);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(266, 25);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(142, 22);
            this.textBoxCodigo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad en existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo producto";
            // 
            // EDITAR_PRODUCTO
            // 
            this.EDITAR_PRODUCTO.Controls.Add(this.numericCmbioPrecioCompra);
            this.EDITAR_PRODUCTO.Controls.Add(this.label10);
            this.EDITAR_PRODUCTO.Controls.Add(this.buttonCambiarProducto);
            this.EDITAR_PRODUCTO.Controls.Add(this.numericCambioExistencia);
            this.EDITAR_PRODUCTO.Controls.Add(this.numericCambioPrecioVenta);
            this.EDITAR_PRODUCTO.Controls.Add(this.label9);
            this.EDITAR_PRODUCTO.Controls.Add(this.label8);
            this.EDITAR_PRODUCTO.Controls.Add(this.label7);
            this.EDITAR_PRODUCTO.Controls.Add(this.comboBox1);
            this.EDITAR_PRODUCTO.Location = new System.Drawing.Point(4, 25);
            this.EDITAR_PRODUCTO.Name = "EDITAR_PRODUCTO";
            this.EDITAR_PRODUCTO.Padding = new System.Windows.Forms.Padding(3);
            this.EDITAR_PRODUCTO.Size = new System.Drawing.Size(1079, 419);
            this.EDITAR_PRODUCTO.TabIndex = 1;
            this.EDITAR_PRODUCTO.Text = "Editar Productos";
            this.EDITAR_PRODUCTO.UseVisualStyleBackColor = true;
            // 
            // numericCmbioPrecioCompra
            // 
            this.numericCmbioPrecioCompra.DecimalPlaces = 2;
            this.numericCmbioPrecioCompra.Location = new System.Drawing.Point(328, 138);
            this.numericCmbioPrecioCompra.Name = "numericCmbioPrecioCompra";
            this.numericCmbioPrecioCompra.Size = new System.Drawing.Size(208, 22);
            this.numericCmbioPrecioCompra.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "precio Compra";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // buttonCambiarProducto
            // 
            this.buttonCambiarProducto.Location = new System.Drawing.Point(691, 106);
            this.buttonCambiarProducto.Name = "buttonCambiarProducto";
            this.buttonCambiarProducto.Size = new System.Drawing.Size(206, 80);
            this.buttonCambiarProducto.TabIndex = 6;
            this.buttonCambiarProducto.Text = "cambiar producto";
            this.buttonCambiarProducto.UseVisualStyleBackColor = true;
            this.buttonCambiarProducto.Click += new System.EventHandler(this.buttonCambiarProducto_Click);
            // 
            // numericCambioExistencia
            // 
            this.numericCambioExistencia.Location = new System.Drawing.Point(310, 301);
            this.numericCambioExistencia.Name = "numericCambioExistencia";
            this.numericCambioExistencia.Size = new System.Drawing.Size(208, 22);
            this.numericCambioExistencia.TabIndex = 5;
            // 
            // numericCambioPrecioVenta
            // 
            this.numericCambioPrecioVenta.DecimalPlaces = 2;
            this.numericCambioPrecioVenta.Location = new System.Drawing.Point(310, 238);
            this.numericCambioPrecioVenta.Name = "numericCambioPrecioVenta";
            this.numericCambioPrecioVenta.Size = new System.Drawing.Size(208, 22);
            this.numericCambioPrecioVenta.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "existencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "precio venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "encuentre produto a modificar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(310, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // REPORTES
            // 
            this.REPORTES.Controls.Add(this.tabControl3);
            this.REPORTES.Location = new System.Drawing.Point(4, 25);
            this.REPORTES.Name = "REPORTES";
            this.REPORTES.Size = new System.Drawing.Size(1079, 419);
            this.REPORTES.TabIndex = 2;
            this.REPORTES.Text = "Reportes";
            this.REPORTES.UseVisualStyleBackColor = true;
            this.REPORTES.Click += new System.EventHandler(this.REPORTES_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.Mas_Vendidos);
            this.tabControl3.Controls.Add(this.Total_Entre_Fechas);
            this.tabControl3.Controls.Add(this.Ganancias_entre_fechas);
            this.tabControl3.Controls.Add(this.Ventas_Pendientes);
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1073, 413);
            this.tabControl3.TabIndex = 0;
            // 
            // Mas_Vendidos
            // 
            this.Mas_Vendidos.Controls.Add(this.datagrid_Reportes_Mas_vendidos);
            this.Mas_Vendidos.Location = new System.Drawing.Point(4, 25);
            this.Mas_Vendidos.Name = "Mas_Vendidos";
            this.Mas_Vendidos.Padding = new System.Windows.Forms.Padding(3);
            this.Mas_Vendidos.Size = new System.Drawing.Size(1065, 384);
            this.Mas_Vendidos.TabIndex = 0;
            this.Mas_Vendidos.Text = " Mas Vendidos";
            this.Mas_Vendidos.UseVisualStyleBackColor = true;
            // 
            // Total_Entre_Fechas
            // 
            this.Total_Entre_Fechas.Location = new System.Drawing.Point(4, 25);
            this.Total_Entre_Fechas.Name = "Total_Entre_Fechas";
            this.Total_Entre_Fechas.Padding = new System.Windows.Forms.Padding(3);
            this.Total_Entre_Fechas.Size = new System.Drawing.Size(1065, 384);
            this.Total_Entre_Fechas.TabIndex = 1;
            this.Total_Entre_Fechas.Text = "Ventas Entre Fechas";
            this.Total_Entre_Fechas.UseVisualStyleBackColor = true;
            // 
            // Ganancias_entre_fechas
            // 
            this.Ganancias_entre_fechas.Location = new System.Drawing.Point(4, 25);
            this.Ganancias_entre_fechas.Name = "Ganancias_entre_fechas";
            this.Ganancias_entre_fechas.Size = new System.Drawing.Size(1065, 384);
            this.Ganancias_entre_fechas.TabIndex = 2;
            this.Ganancias_entre_fechas.Text = "Ganancia entre Fechas";
            this.Ganancias_entre_fechas.UseVisualStyleBackColor = true;
            // 
            // Ventas_Pendientes
            // 
            this.Ventas_Pendientes.Location = new System.Drawing.Point(4, 25);
            this.Ventas_Pendientes.Name = "Ventas_Pendientes";
            this.Ventas_Pendientes.Size = new System.Drawing.Size(1065, 384);
            this.Ventas_Pendientes.TabIndex = 3;
            this.Ventas_Pendientes.Text = "Ventas pendientes de entrega";
            this.Ventas_Pendientes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1099, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // datagrid_Reportes_Mas_vendidos
            // 
            this.datagrid_Reportes_Mas_vendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Reportes_Mas_vendidos.Location = new System.Drawing.Point(6, 27);
            this.datagrid_Reportes_Mas_vendidos.Name = "datagrid_Reportes_Mas_vendidos";
            this.datagrid_Reportes_Mas_vendidos.RowHeadersWidth = 51;
            this.datagrid_Reportes_Mas_vendidos.RowTemplate.Height = 24;
            this.datagrid_Reportes_Mas_vendidos.Size = new System.Drawing.Size(1053, 351);
            this.datagrid_Reportes_Mas_vendidos.TabIndex = 0;
            this.datagrid_Reportes_Mas_vendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Reportes_Mas_vendidos_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 524);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.AGREGAR_NUEVO_PRODUCTO.ResumeLayout(false);
            this.AGREGAR_NUEVO_PRODUCTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriPrecioCompra)).EndInit();
            this.EDITAR_PRODUCTO.ResumeLayout(false);
            this.EDITAR_PRODUCTO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCmbioPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCambioExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCambioPrecioVenta)).EndInit();
            this.REPORTES.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.Mas_Vendidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Reportes_Mas_vendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage AGREGAR_NUEVO_PRODUCTO;
        private System.Windows.Forms.TabPage EDITAR_PRODUCTO;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIngresoProducto;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.NumericUpDown numericPrecioVenta;
        private System.Windows.Forms.NumericUpDown numeriPrecioCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCambiarProducto;
        private System.Windows.Forms.NumericUpDown numericCambioExistencia;
        private System.Windows.Forms.NumericUpDown numericCambioPrecioVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericCmbioPrecioCompra;
        private System.Windows.Forms.TabPage REPORTES;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage Mas_Vendidos;
        private System.Windows.Forms.TabPage Total_Entre_Fechas;
        private System.Windows.Forms.TabPage Ganancias_entre_fechas;
        private System.Windows.Forms.TabPage Ventas_Pendientes;
        private System.Windows.Forms.DataGridView datagrid_Reportes_Mas_vendidos;
    }
}

