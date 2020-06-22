namespace WindowsFormsApp1
{
    partial class Master
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idEntrevistadoLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label fechaEntrevistaLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label paisLabel;
            this.busquedaDataSet = new WindowsFormsApp1.BusquedaDataSet();
            this.desaparecidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desaparecidoTableAdapter = new WindowsFormsApp1.BusquedaDataSetTableAdapters.DesaparecidoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.BusquedaDataSetTableAdapters.TableAdapterManager();
            this.entrevistadoTableAdapter = new WindowsFormsApp1.BusquedaDataSetTableAdapters.EntrevistadoTableAdapter();
            this.entrevistadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.desaparecidoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEntrevistadoComboBox = new System.Windows.Forms.ComboBox();
            this.nombreCompletoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaEntrevistaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            idEntrevistadoLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            fechaEntrevistaLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoDataGridView)).BeginInit();
            this.pnlNavegacion.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // busquedaDataSet
            // 
            this.busquedaDataSet.DataSetName = "BusquedaDataSet";
            this.busquedaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // desaparecidoBindingSource
            // 
            this.desaparecidoBindingSource.DataMember = "Desaparecido";
            this.desaparecidoBindingSource.DataSource = this.busquedaDataSet;
            // 
            // desaparecidoTableAdapter
            // 
            this.desaparecidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DesaparecidoTableAdapter = this.desaparecidoTableAdapter;
            this.tableAdapterManager.EntrevistadoTableAdapter = this.entrevistadoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.BusquedaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // entrevistadoTableAdapter
            // 
            this.entrevistadoTableAdapter.ClearBeforeFill = true;
            // 
            // entrevistadoBindingSource
            // 
            this.entrevistadoBindingSource.DataMember = "Entrevistado";
            this.entrevistadoBindingSource.DataSource = this.busquedaDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Volver al menú principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // desaparecidoDataGridView
            // 
            this.desaparecidoDataGridView.AutoGenerateColumns = false;
            this.desaparecidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desaparecidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.desaparecidoDataGridView.DataSource = this.desaparecidoBindingSource;
            this.desaparecidoDataGridView.Location = new System.Drawing.Point(32, 207);
            this.desaparecidoDataGridView.Name = "desaparecidoDataGridView";
            this.desaparecidoDataGridView.Size = new System.Drawing.Size(443, 220);
            this.desaparecidoDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDesaparecido";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDesaparecido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCompleto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreCompleto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PreferenciaSexual";
            this.dataGridViewTextBoxColumn5.HeaderText = "PreferenciaSexual";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha de nacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de nacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // idEntrevistadoLabel
            // 
            idEntrevistadoLabel.AutoSize = true;
            idEntrevistadoLabel.Location = new System.Drawing.Point(57, 47);
            idEntrevistadoLabel.Name = "idEntrevistadoLabel";
            idEntrevistadoLabel.Size = new System.Drawing.Size(81, 13);
            idEntrevistadoLabel.TabIndex = 15;
            idEntrevistadoLabel.Text = "Id Entrevistado:";
            // 
            // idEntrevistadoComboBox
            // 
            this.idEntrevistadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrevistadoBindingSource, "IdEntrevistado", true));
            this.idEntrevistadoComboBox.FormattingEnabled = true;
            this.idEntrevistadoComboBox.Location = new System.Drawing.Point(159, 44);
            this.idEntrevistadoComboBox.Name = "idEntrevistadoComboBox";
            this.idEntrevistadoComboBox.Size = new System.Drawing.Size(200, 21);
            this.idEntrevistadoComboBox.TabIndex = 16;
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Location = new System.Drawing.Point(57, 74);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(94, 13);
            nombreCompletoLabel.TabIndex = 17;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // nombreCompletoComboBox
            // 
            this.nombreCompletoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrevistadoBindingSource, "NombreCompleto", true));
            this.nombreCompletoComboBox.FormattingEnabled = true;
            this.nombreCompletoComboBox.Location = new System.Drawing.Point(159, 71);
            this.nombreCompletoComboBox.Name = "nombreCompletoComboBox";
            this.nombreCompletoComboBox.Size = new System.Drawing.Size(200, 21);
            this.nombreCompletoComboBox.TabIndex = 18;
            // 
            // fechaEntrevistaLabel
            // 
            fechaEntrevistaLabel.AutoSize = true;
            fechaEntrevistaLabel.Location = new System.Drawing.Point(57, 102);
            fechaEntrevistaLabel.Name = "fechaEntrevistaLabel";
            fechaEntrevistaLabel.Size = new System.Drawing.Size(90, 13);
            fechaEntrevistaLabel.TabIndex = 19;
            fechaEntrevistaLabel.Text = "Fecha Entrevista:";
            // 
            // fechaEntrevistaDateTimePicker
            // 
            this.fechaEntrevistaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.entrevistadoBindingSource, "FechaEntrevista", true));
            this.fechaEntrevistaDateTimePicker.Location = new System.Drawing.Point(159, 98);
            this.fechaEntrevistaDateTimePicker.Name = "fechaEntrevistaDateTimePicker";
            this.fechaEntrevistaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntrevistaDateTimePicker.TabIndex = 20;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(57, 128);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 21;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.entrevistadoBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(159, 124);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 22;
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(57, 153);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 23;
            paisLabel.Text = "Pais:";
            // 
            // paisComboBox
            // 
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrevistadoBindingSource, "Pais", true));
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(159, 150);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(200, 21);
            this.paisComboBox.TabIndex = 24;
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.Controls.Add(this.lblregistroxden);
            this.pnlNavegacion.Controls.Add(this.btnUltimo);
            this.pnlNavegacion.Controls.Add(this.btnSiguiente);
            this.pnlNavegacion.Controls.Add(this.btnAnterior);
            this.pnlNavegacion.Controls.Add(this.btnPrimero);
            this.pnlNavegacion.Location = new System.Drawing.Point(32, 462);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(191, 49);
            this.pnlNavegacion.TabIndex = 25;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(67, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(156, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(32, 38);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(125, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(33, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 38);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(2, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(32, 38);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.Controls.Add(this.btnImprimir);
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Location = new System.Drawing.Point(250, 462);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(300, 49);
            this.pnlEdicion.TabIndex = 26;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(221, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 38);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(171, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(120, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(59, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(63, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 575);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(idEntrevistadoLabel);
            this.Controls.Add(this.idEntrevistadoComboBox);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoComboBox);
            this.Controls.Add(fechaEntrevistaLabel);
            this.Controls.Add(this.fechaEntrevistaDateTimePicker);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.desaparecidoDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Master";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoDataGridView)).EndInit();
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            this.pnlEdicion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BusquedaDataSet busquedaDataSet;
        private System.Windows.Forms.BindingSource desaparecidoBindingSource;
        private BusquedaDataSetTableAdapters.DesaparecidoTableAdapter desaparecidoTableAdapter;
        private BusquedaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BusquedaDataSetTableAdapters.EntrevistadoTableAdapter entrevistadoTableAdapter;
        private System.Windows.Forms.BindingSource entrevistadoBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView desaparecidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox idEntrevistadoComboBox;
        private System.Windows.Forms.ComboBox nombreCompletoComboBox;
        private System.Windows.Forms.DateTimePicker fechaEntrevistaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
    }
}