namespace Practico2
{
    partial class Form2
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
            this.LAya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.Ttelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TNuevo_cliente = new System.Windows.Forms.Label();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.BSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TEliminar = new System.Windows.Forms.Button();
            this.TGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LAya
            // 
            this.LAya.AutoSize = true;
            this.LAya.Location = new System.Drawing.Point(12, 12);
            this.LAya.Name = "LAya";
            this.LAya.Size = new System.Drawing.Size(122, 16);
            this.LAya.TabIndex = 0;
            this.LAya.Text = "Nombre y Apellido:";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(164, 12);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(62, 16);
            this.LModificar.TabIndex = 1;
            this.LModificar.Text = "modificar";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(12, 51);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 16);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(12, 98);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(57, 16);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            this.LApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(12, 142);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(56, 16);
            this.LNombre.TabIndex = 4;
            this.LNombre.Text = "Nombre";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(128, 48);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(120, 22);
            this.TDni.TabIndex = 5;
            this.TDni.Click += new System.EventHandler(this.TDni_Click);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(128, 92);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(120, 22);
            this.TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(128, 136);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(118, 22);
            this.TNombre.TabIndex = 7;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(12, 194);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(61, 16);
            this.LTelefono.TabIndex = 10;
            this.LTelefono.Text = "Telefono";
            // 
            // Ttelefono
            // 
            this.Ttelefono.Location = new System.Drawing.Point(128, 188);
            this.Ttelefono.Name = "Ttelefono";
            this.Ttelefono.Size = new System.Drawing.Size(120, 22);
            this.Ttelefono.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tarjetas de credito:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(149, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Naranja";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(149, 288);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(56, 20);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Visa";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(149, 331);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 20);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Mastercard";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Ttelefono);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.LAya);
            this.panel1.Location = new System.Drawing.Point(58, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 380);
            this.panel1.TabIndex = 16;
            // 
            // TNuevo_cliente
            // 
            this.TNuevo_cliente.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNuevo_cliente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TNuevo_cliente.Location = new System.Drawing.Point(204, 9);
            this.TNuevo_cliente.Name = "TNuevo_cliente";
            this.TNuevo_cliente.Size = new System.Drawing.Size(200, 50);
            this.TNuevo_cliente.TabIndex = 17;
            this.TNuevo_cliente.Text = "Nuevo Cliente";
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RBVaron.Location = new System.Drawing.Point(391, 231);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(64, 20);
            this.RBVaron.TabIndex = 19;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varon";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(481, 231);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(61, 20);
            this.RBMujer.TabIndex = 20;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // BSalir
            // 
            this.BSalir.Image = global::Practico2.Properties.Resources.salir;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(383, 483);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(77, 51);
            this.BSalir.TabIndex = 21;
            this.BSalir.Text = "Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TEliminar
            // 
            this.TEliminar.Image = global::Practico2.Properties.Resources.eliminar;
            this.TEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TEliminar.Location = new System.Drawing.Point(211, 481);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(109, 55);
            this.TEliminar.TabIndex = 9;
            this.TEliminar.Text = "Eliminar";
            this.TEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // TGuardar
            // 
            this.TGuardar.Image = global::Practico2.Properties.Resources.save;
            this.TGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TGuardar.Location = new System.Drawing.Point(73, 481);
            this.TGuardar.Name = "TGuardar";
            this.TGuardar.Size = new System.Drawing.Size(112, 55);
            this.TGuardar.TabIndex = 8;
            this.TGuardar.Text = "Guardar";
            this.TGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TGuardar.UseVisualStyleBackColor = true;
            this.TGuardar.Click += new System.EventHandler(this.TGuardar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 628);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TNuevo_cliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TEliminar);
            this.Controls.Add(this.TGuardar);
            this.Name = "Form2";
            this.Text = "Pequeño Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button TGuardar;
        private System.Windows.Forms.Button TEliminar;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox Ttelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TNuevo_cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.Button BSalir;
    }
}

