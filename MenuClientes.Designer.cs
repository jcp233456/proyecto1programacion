namespace proyecto1programacion
{
    partial class MenuClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxVentaProducto = new System.Windows.Forms.ComboBox();
            this.comboBoxVentaNit = new System.Windows.Forms.ComboBox();
            this.buttonVenta = new System.Windows.Forms.Button();
            this.textBoxVentaCantidad = new System.Windows.Forms.TextBox();
            this.checkBoxNoEntregado = new System.Windows.Forms.CheckBox();
            this.checkBoxEntregado = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxVentaProducto
            // 
            this.comboBoxVentaProducto.FormattingEnabled = true;
            this.comboBoxVentaProducto.Location = new System.Drawing.Point(161, 96);
            this.comboBoxVentaProducto.Name = "comboBoxVentaProducto";
            this.comboBoxVentaProducto.Size = new System.Drawing.Size(130, 23);
            this.comboBoxVentaProducto.TabIndex = 22;
            // 
            // comboBoxVentaNit
            // 
            this.comboBoxVentaNit.FormattingEnabled = true;
            this.comboBoxVentaNit.Location = new System.Drawing.Point(161, 6);
            this.comboBoxVentaNit.Name = "comboBoxVentaNit";
            this.comboBoxVentaNit.Size = new System.Drawing.Size(130, 23);
            this.comboBoxVentaNit.TabIndex = 21;
            // 
            // buttonVenta
            // 
            this.buttonVenta.Location = new System.Drawing.Point(424, 54);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(173, 52);
            this.buttonVenta.TabIndex = 20;
            this.buttonVenta.Text = "Registrar venta";
            this.buttonVenta.UseVisualStyleBackColor = true;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // textBoxVentaCantidad
            // 
            this.textBoxVentaCantidad.Location = new System.Drawing.Point(161, 54);
            this.textBoxVentaCantidad.Name = "textBoxVentaCantidad";
            this.textBoxVentaCantidad.Size = new System.Drawing.Size(138, 25);
            this.textBoxVentaCantidad.TabIndex = 19;
            // 
            // checkBoxNoEntregado
            // 
            this.checkBoxNoEntregado.AutoSize = true;
            this.checkBoxNoEntregado.Location = new System.Drawing.Point(276, 150);
            this.checkBoxNoEntregado.Name = "checkBoxNoEntregado";
            this.checkBoxNoEntregado.Size = new System.Drawing.Size(109, 19);
            this.checkBoxNoEntregado.TabIndex = 18;
            this.checkBoxNoEntregado.Text = "No entregado ";
            this.checkBoxNoEntregado.UseVisualStyleBackColor = true;
            // 
            // checkBoxEntregado
            // 
            this.checkBoxEntregado.AutoSize = true;
            this.checkBoxEntregado.Location = new System.Drawing.Point(161, 150);
            this.checkBoxEntregado.Name = "checkBoxEntregado";
            this.checkBoxEntregado.Size = new System.Drawing.Size(88, 19);
            this.checkBoxEntregado.TabIndex = 17;
            this.checkBoxEntregado.Text = "entregado ";
            this.checkBoxEntregado.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 16;
            this.label20.Text = "cantidad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 15);
            this.label19.TabIndex = 15;
            this.label19.Text = "Estado de la venta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Nit cliente";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 15);
            this.label16.TabIndex = 13;
            this.label16.Text = "producto";
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(546, 5);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 23);
            this.returnBtn.TabIndex = 23;
            this.returnBtn.Text = "Regresar";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // MenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 199);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.comboBoxVentaProducto);
            this.Controls.Add(this.comboBoxVentaNit);
            this.Controls.Add(this.buttonVenta);
            this.Controls.Add(this.textBoxVentaCantidad);
            this.Controls.Add(this.checkBoxNoEntregado);
            this.Controls.Add(this.checkBoxEntregado);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Name = "MenuClientes";
            this.Text = "MenuClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVentaProducto;
        private System.Windows.Forms.ComboBox comboBoxVentaNit;
        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.TextBox textBoxVentaCantidad;
        private System.Windows.Forms.CheckBox checkBoxNoEntregado;
        private System.Windows.Forms.CheckBox checkBoxEntregado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button returnBtn;
    }
}