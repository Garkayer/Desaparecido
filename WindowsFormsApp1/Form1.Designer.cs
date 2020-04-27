namespace WindowsFormsApp1
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
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.lblidCliente = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtPaís = new System.Windows.Forms.TextBox();
            this.lblPaís = new System.Windows.Forms.Label();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.txtFechaDeEntrevista = new System.Windows.Forms.TextBox();
            this.lblFechaDeEntrevista = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbDatosClientes.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.BackColor = System.Drawing.Color.Transparent;
            this.grbDatosClientes.Controls.Add(this.lblidCliente);
            this.grbDatosClientes.Controls.Add(this.txtMunicipio);
            this.grbDatosClientes.Controls.Add(this.lblMunicipio);
            this.grbDatosClientes.Controls.Add(this.textBox6);
            this.grbDatosClientes.Controls.Add(this.label6);
            this.grbDatosClientes.Controls.Add(this.txtDepartamento);
            this.grbDatosClientes.Controls.Add(this.lblDepartamento);
            this.grbDatosClientes.Controls.Add(this.txtPaís);
            this.grbDatosClientes.Controls.Add(this.lblPaís);
            this.grbDatosClientes.Controls.Add(this.txtFechaDeNacimiento);
            this.grbDatosClientes.Controls.Add(this.lblFechaDeNacimiento);
            this.grbDatosClientes.Controls.Add(this.txtFechaDeEntrevista);
            this.grbDatosClientes.Controls.Add(this.lblFechaDeEntrevista);
            this.grbDatosClientes.Controls.Add(this.txtNombreCompleto);
            this.grbDatosClientes.Controls.Add(this.lblNombreCompleto);
            this.grbDatosClientes.Enabled = false;
            this.grbDatosClientes.Location = new System.Drawing.Point(467, 23);
            this.grbDatosClientes.Margin = new System.Windows.Forms.Padding(1);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Padding = new System.Windows.Forms.Padding(1);
            this.grbDatosClientes.Size = new System.Drawing.Size(393, 244);
            this.grbDatosClientes.TabIndex = 1;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "Datos de la persona entrevistada";
            // 
            // lblidCliente
            // 
            this.lblidCliente.AutoSize = true;
            this.lblidCliente.Location = new System.Drawing.Point(269, 35);
            this.lblidCliente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidCliente.Name = "lblidCliente";
            this.lblidCliente.Size = new System.Drawing.Size(21, 13);
            this.lblidCliente.TabIndex = 12;
            this.lblidCliente.Text = "ID:";
            this.lblidCliente.Click += new System.EventHandler(this.lblidCliente_Click);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(124, 203);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(1);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(137, 20);
            this.txtMunicipio.TabIndex = 11;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(18, 203);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(55, 13);
            this.lblMunicipio.TabIndex = 10;
            this.lblMunicipio.Text = "Municipio:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 568);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(124, 167);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(1);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(137, 20);
            this.txtDepartamento.TabIndex = 7;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.Location = new System.Drawing.Point(17, 174);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtPaís
            // 
            this.txtPaís.Location = new System.Drawing.Point(124, 136);
            this.txtPaís.Margin = new System.Windows.Forms.Padding(1);
            this.txtPaís.Name = "txtPaís";
            this.txtPaís.Size = new System.Drawing.Size(81, 20);
            this.txtPaís.TabIndex = 5;
            // 
            // lblPaís
            // 
            this.lblPaís.AutoSize = true;
            this.lblPaís.Location = new System.Drawing.Point(15, 139);
            this.lblPaís.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPaís.Name = "lblPaís";
            this.lblPaís.Size = new System.Drawing.Size(32, 13);
            this.lblPaís.TabIndex = 4;
            this.lblPaís.Text = "País:";
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(124, 100);
            this.txtFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(1);
            this.txtFechaDeNacimiento.Multiline = true;
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(210, 27);
            this.txtFechaDeNacimiento.TabIndex = 3;
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(13, 103);
            this.lblFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaDeNacimiento.TabIndex = 2;
            this.lblFechaDeNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtFechaDeEntrevista
            // 
            this.txtFechaDeEntrevista.Location = new System.Drawing.Point(124, 63);
            this.txtFechaDeEntrevista.Margin = new System.Windows.Forms.Padding(1);
            this.txtFechaDeEntrevista.Name = "txtFechaDeEntrevista";
            this.txtFechaDeEntrevista.Size = new System.Drawing.Size(205, 20);
            this.txtFechaDeEntrevista.TabIndex = 3;
            this.txtFechaDeEntrevista.TextChanged += new System.EventHandler(this.txtFechaDeEntrevista_TextChanged);
            // 
            // lblFechaDeEntrevista
            // 
            this.lblFechaDeEntrevista.AutoSize = true;
            this.lblFechaDeEntrevista.Location = new System.Drawing.Point(4, 63);
            this.lblFechaDeEntrevista.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFechaDeEntrevista.Name = "lblFechaDeEntrevista";
            this.lblFechaDeEntrevista.Size = new System.Drawing.Size(104, 13);
            this.lblFechaDeEntrevista.TabIndex = 2;
            this.lblFechaDeEntrevista.Text = "Fecha de entrevista:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(124, 32);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(143, 20);
            this.txtNombreCompleto.TabIndex = 1;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(15, 35);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(93, 13);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre completo:";
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.BackColor = System.Drawing.Color.Transparent;
            this.grbNavegacion.Controls.Add(this.btnultimo);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Controls.Add(this.btnanterior);
            this.grbNavegacion.Controls.Add(this.btnprimero);
            this.grbNavegacion.Controls.Add(this.lblnregistros);
            this.grbNavegacion.Location = new System.Drawing.Point(412, 355);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Size = new System.Drawing.Size(228, 65);
            this.grbNavegacion.TabIndex = 2;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // btnultimo
            // 
            this.btnultimo.BackColor = System.Drawing.Color.White;
            this.btnultimo.Location = new System.Drawing.Point(165, 20);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(44, 35);
            this.btnultimo.TabIndex = 18;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = false;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click_1);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.White;
            this.btnsiguiente.Location = new System.Drawing.Point(114, 20);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(49, 35);
            this.btnsiguiente.TabIndex = 17;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            // 
            // btnanterior
            // 
            this.btnanterior.BackColor = System.Drawing.Color.White;
            this.btnanterior.Location = new System.Drawing.Point(62, 20);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(46, 35);
            this.btnanterior.TabIndex = 16;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = false;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click_1);
            // 
            // btnprimero
            // 
            this.btnprimero.BackColor = System.Drawing.Color.White;
            this.btnprimero.Location = new System.Drawing.Point(13, 20);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(47, 35);
            this.btnprimero.TabIndex = 15;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = false;
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(111, 22);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 14;
            // 
            // grbEdicion
            // 
            this.grbEdicion.BackColor = System.Drawing.Color.Transparent;
            this.grbEdicion.Controls.Add(this.btnBuscar);
            this.grbEdicion.Controls.Add(this.btneliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(665, 355);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(273, 65);
            this.grbEdicion.TabIndex = 3;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de la persona entrevistada";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(196, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 33);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(132, 20);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(62, 33);
            this.btneliminar.TabIndex = 5;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(68, 20);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 33);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(11, 20);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(55, 33);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.miles_de_personas_desaparecen_al_ano_una_mujer_las_conoce_a_todas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatosClientes);
            this.Name = "Form1";
            this.Text = "Busqueda de desaparecidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatosClientes.ResumeLayout(false);
            this.grbDatosClientes.PerformLayout();
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.Label lblidCliente;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtPaís;
        private System.Windows.Forms.Label lblPaís;
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.TextBox txtFechaDeEntrevista;
        private System.Windows.Forms.Label lblFechaDeEntrevista;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
    }
}

