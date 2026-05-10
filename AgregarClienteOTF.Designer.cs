namespace proyecto1programacion
{
    partial class AgregarClienteOTF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteAgregarOTF = new System.Windows.Forms.Button();
            this.clienteNitOTF = new System.Windows.Forms.TextBox();
            this.clienteNombreOTF = new System.Windows.Forms.TextBox();
            this.clienteApellidoOTF = new System.Windows.Forms.TextBox();
            this.clienteDireccionOTF = new System.Windows.Forms.TextBox();
            this.clienteTelefonoOTF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // clienteAgregarOTF
            // 
            this.clienteAgregarOTF.Location = new System.Drawing.Point(245, 161);
            this.clienteAgregarOTF.Name = "clienteAgregarOTF";
            this.clienteAgregarOTF.Size = new System.Drawing.Size(75, 23);
            this.clienteAgregarOTF.TabIndex = 5;
            this.clienteAgregarOTF.Text = "Agregar";
            this.clienteAgregarOTF.UseVisualStyleBackColor = true;
            this.clienteAgregarOTF.Click += new System.EventHandler(this.clienteAgregarOTF_Click);
            // 
            // clienteNitOTF
            // 
            this.clienteNitOTF.Location = new System.Drawing.Point(82, 6);
            this.clienteNitOTF.Name = "clienteNitOTF";
            this.clienteNitOTF.Size = new System.Drawing.Size(238, 25);
            this.clienteNitOTF.TabIndex = 6;
            // 
            // clienteNombreOTF
            // 
            this.clienteNombreOTF.Location = new System.Drawing.Point(82, 37);
            this.clienteNombreOTF.Name = "clienteNombreOTF";
            this.clienteNombreOTF.Size = new System.Drawing.Size(238, 25);
            this.clienteNombreOTF.TabIndex = 7;
            // 
            // clienteApellidoOTF
            // 
            this.clienteApellidoOTF.Location = new System.Drawing.Point(82, 68);
            this.clienteApellidoOTF.Name = "clienteApellidoOTF";
            this.clienteApellidoOTF.Size = new System.Drawing.Size(238, 25);
            this.clienteApellidoOTF.TabIndex = 8;
            // 
            // clienteDireccionOTF
            // 
            this.clienteDireccionOTF.Location = new System.Drawing.Point(82, 99);
            this.clienteDireccionOTF.Name = "clienteDireccionOTF";
            this.clienteDireccionOTF.Size = new System.Drawing.Size(238, 25);
            this.clienteDireccionOTF.TabIndex = 9;
            // 
            // clienteTelefonoOTF
            // 
            this.clienteTelefonoOTF.Location = new System.Drawing.Point(82, 130);
            this.clienteTelefonoOTF.Name = "clienteTelefonoOTF";
            this.clienteTelefonoOTF.Size = new System.Drawing.Size(238, 25);
            this.clienteTelefonoOTF.TabIndex = 10;
            // 
            // AgregarClienteOTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 195);
            this.Controls.Add(this.clienteTelefonoOTF);
            this.Controls.Add(this.clienteDireccionOTF);
            this.Controls.Add(this.clienteApellidoOTF);
            this.Controls.Add(this.clienteNombreOTF);
            this.Controls.Add(this.clienteNitOTF);
            this.Controls.Add(this.clienteAgregarOTF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarClienteOTF";
            this.Text = "Agregar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarClienteOTF_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clienteAgregarOTF;
        private System.Windows.Forms.TextBox clienteNitOTF;
        private System.Windows.Forms.TextBox clienteNombreOTF;
        private System.Windows.Forms.TextBox clienteApellidoOTF;
        private System.Windows.Forms.TextBox clienteDireccionOTF;
        private System.Windows.Forms.TextBox clienteTelefonoOTF;
    }
}