﻿namespace WindowsFormsApp1
{
    partial class Entrevistado
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
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbDatosEntrevistado = new System.Windows.Forms.GroupBox();
            this.lblIdEntrevistado = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lbldui = new System.Windows.Forms.Label();
            this.txtFechaDeNacimiento = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtFechaDeEntrevista = new System.Windows.Forms.TextBox();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.grbDatosEntrevistado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.BackColor = System.Drawing.Color.Yellow;
            this.grbNavegacion.Controls.Add(this.lblnregistros);
            this.grbNavegacion.Controls.Add(this.btnultimo);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Controls.Add(this.btnprimero);
            this.grbNavegacion.Controls.Add(this.btnanterior);
            this.grbNavegacion.Location = new System.Drawing.Point(33, 349);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Size = new System.Drawing.Size(222, 57);
            this.grbNavegacion.TabIndex = 5;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(83, 26);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 13;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(160, 15);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 33);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(118, 15);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 33);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(4, 15);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(35, 33);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(41, 15);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 33);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // grbEdicion
            // 
            this.grbEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbEdicion.Controls.Add(this.btnEliminar);
            this.grbEdicion.Controls.Add(this.btnBuscar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(287, 349);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(236, 57);
            this.grbEdicion.TabIndex = 6;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(107, 15);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 33);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(171, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 33);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(45, 16);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 33);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(2, 16);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 33);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbDatosEntrevistado
            // 
            this.grbDatosEntrevistado.BackColor = System.Drawing.Color.Yellow;
            this.grbDatosEntrevistado.Controls.Add(this.txtFechaDeEntrevista);
            this.grbDatosEntrevistado.Controls.Add(this.lblIdEntrevistado);
            this.grbDatosEntrevistado.Controls.Add(this.textBox6);
            this.grbDatosEntrevistado.Controls.Add(this.label6);
            this.grbDatosEntrevistado.Controls.Add(this.txtPais);
            this.grbDatosEntrevistado.Controls.Add(this.lbldui);
            this.grbDatosEntrevistado.Controls.Add(this.txtFechaDeNacimiento);
            this.grbDatosEntrevistado.Controls.Add(this.lbltelefono);
            this.grbDatosEntrevistado.Controls.Add(this.lbldireccion);
            this.grbDatosEntrevistado.Controls.Add(this.txtNombreCompleto);
            this.grbDatosEntrevistado.Controls.Add(this.lblnombre);
            this.grbDatosEntrevistado.Enabled = false;
            this.grbDatosEntrevistado.Location = new System.Drawing.Point(33, 38);
            this.grbDatosEntrevistado.Margin = new System.Windows.Forms.Padding(1);
            this.grbDatosEntrevistado.Name = "grbDatosEntrevistado";
            this.grbDatosEntrevistado.Padding = new System.Windows.Forms.Padding(1);
            this.grbDatosEntrevistado.Size = new System.Drawing.Size(459, 281);
            this.grbDatosEntrevistado.TabIndex = 7;
            this.grbDatosEntrevistado.TabStop = false;
            this.grbDatosEntrevistado.Text = "Datos de entrevistado";
            // 
            // lblIdEntrevistado
            // 
            this.lblIdEntrevistado.AutoSize = true;
            this.lblIdEntrevistado.Location = new System.Drawing.Point(18, 29);
            this.lblIdEntrevistado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblIdEntrevistado.Name = "lblIdEntrevistado";
            this.lblIdEntrevistado.Size = new System.Drawing.Size(21, 13);
            this.lblIdEntrevistado.TabIndex = 12;
            this.lblIdEntrevistado.Text = "ID:";
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
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(47, 165);
            this.txtPais.Margin = new System.Windows.Forms.Padding(1);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(276, 20);
            this.txtPais.TabIndex = 7;
            // 
            // lbldui
            // 
            this.lbldui.AutoSize = true;
            this.lbldui.Location = new System.Drawing.Point(13, 165);
            this.lbldui.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldui.Name = "lbldui";
            this.lbldui.Size = new System.Drawing.Size(32, 13);
            this.lbldui.TabIndex = 6;
            this.lbldui.Text = "País:";
            // 
            // txtFechaDeNacimiento
            // 
            this.txtFechaDeNacimiento.Location = new System.Drawing.Point(124, 134);
            this.txtFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(1);
            this.txtFechaDeNacimiento.Name = "txtFechaDeNacimiento";
            this.txtFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.txtFechaDeNacimiento.TabIndex = 5;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(15, 134);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(109, 13);
            this.lbltelefono.TabIndex = 4;
            this.lbltelefono.Text = "Fecha de nacimiento:";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(13, 103);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(104, 13);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "Fecha de entrevista:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(118, 60);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(205, 20);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(15, 63);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(93, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre completo:";
            // 
            // txtFechaDeEntrevista
            // 
            this.txtFechaDeEntrevista.Location = new System.Drawing.Point(119, 103);
            this.txtFechaDeEntrevista.Margin = new System.Windows.Forms.Padding(1);
            this.txtFechaDeEntrevista.Name = "txtFechaDeEntrevista";
            this.txtFechaDeEntrevista.Size = new System.Drawing.Size(205, 20);
            this.txtFechaDeEntrevista.TabIndex = 13;
            // 
            // Entrevistado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDatosEntrevistado);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Name = "Entrevistado";
            this.Text = "Personas Entrevistadas";
            this.Load += new System.EventHandler(this.Entrevistado_Load);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            this.grbDatosEntrevistado.ResumeLayout(false);
            this.grbDatosEntrevistado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbDatosEntrevistado;
        private System.Windows.Forms.Label lblIdEntrevistado;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lbldui;
        private System.Windows.Forms.TextBox txtFechaDeNacimiento;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtFechaDeEntrevista;
    }
}