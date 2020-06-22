namespace WindowsFormsApp1
{
    partial class Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control));
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label fechaEntrevistaLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label paisLabel;
            this.busquedaDataSet = new WindowsFormsApp1.BusquedaDataSet();
            this.entrevistadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrevistadoTableAdapter = new WindowsFormsApp1.BusquedaDataSetTableAdapters.EntrevistadoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.BusquedaDataSetTableAdapters.TableAdapterManager();
            this.entrevistadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.entrevistadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreCompletoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaEntrevistaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.desaparecidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desaparecidoTableAdapter = new WindowsFormsApp1.BusquedaDataSetTableAdapters.DesaparecidoTableAdapter();
            this.desaparecidoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            fechaEntrevistaLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingNavigator)).BeginInit();
            this.entrevistadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // busquedaDataSet
            // 
            this.busquedaDataSet.DataSetName = "BusquedaDataSet";
            this.busquedaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entrevistadoBindingSource
            // 
            this.entrevistadoBindingSource.DataMember = "Entrevistado";
            this.entrevistadoBindingSource.DataSource = this.busquedaDataSet;
            // 
            // entrevistadoTableAdapter
            // 
            this.entrevistadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DesaparecidoTableAdapter = this.desaparecidoTableAdapter;
            this.tableAdapterManager.EntrevistadoTableAdapter = this.entrevistadoTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.BusquedaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // entrevistadoBindingNavigator
            // 
            this.entrevistadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.entrevistadoBindingNavigator.BindingSource = this.entrevistadoBindingSource;
            this.entrevistadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.entrevistadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.entrevistadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.entrevistadoBindingNavigatorSaveItem});
            this.entrevistadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.entrevistadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.entrevistadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.entrevistadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.entrevistadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.entrevistadoBindingNavigator.Name = "entrevistadoBindingNavigator";
            this.entrevistadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.entrevistadoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.entrevistadoBindingNavigator.TabIndex = 0;
            this.entrevistadoBindingNavigator.Text = "bindingNavigator1";
            this.entrevistadoBindingNavigator.RefreshItems += new System.EventHandler(this.entrevistadoBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // entrevistadoBindingNavigatorSaveItem
            // 
            this.entrevistadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.entrevistadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entrevistadoBindingNavigatorSaveItem.Image")));
            this.entrevistadoBindingNavigatorSaveItem.Name = "entrevistadoBindingNavigatorSaveItem";
            this.entrevistadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.entrevistadoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.entrevistadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.entrevistadoBindingNavigatorSaveItem_Click_1);
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Location = new System.Drawing.Point(69, 70);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(94, 13);
            nombreCompletoLabel.TabIndex = 3;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // nombreCompletoComboBox
            // 
            this.nombreCompletoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrevistadoBindingSource, "NombreCompleto", true));
            this.nombreCompletoComboBox.FormattingEnabled = true;
            this.nombreCompletoComboBox.Location = new System.Drawing.Point(171, 70);
            this.nombreCompletoComboBox.Name = "nombreCompletoComboBox";
            this.nombreCompletoComboBox.Size = new System.Drawing.Size(200, 21);
            this.nombreCompletoComboBox.TabIndex = 4;
            // 
            // fechaEntrevistaLabel
            // 
            fechaEntrevistaLabel.AutoSize = true;
            fechaEntrevistaLabel.Location = new System.Drawing.Point(69, 100);
            fechaEntrevistaLabel.Name = "fechaEntrevistaLabel";
            fechaEntrevistaLabel.Size = new System.Drawing.Size(90, 13);
            fechaEntrevistaLabel.TabIndex = 5;
            fechaEntrevistaLabel.Text = "Fecha Entrevista:";
            // 
            // fechaEntrevistaDateTimePicker
            // 
            this.fechaEntrevistaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.entrevistadoBindingSource, "FechaEntrevista", true));
            this.fechaEntrevistaDateTimePicker.Location = new System.Drawing.Point(171, 100);
            this.fechaEntrevistaDateTimePicker.Name = "fechaEntrevistaDateTimePicker";
            this.fechaEntrevistaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaEntrevistaDateTimePicker.TabIndex = 6;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(69, 130);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 7;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.entrevistadoBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(171, 130);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 8;
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(69, 163);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 9;
            paisLabel.Text = "Pais:";
            // 
            // paisComboBox
            // 
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entrevistadoBindingSource, "Pais", true));
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(171, 160);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(200, 21);
            this.paisComboBox.TabIndex = 10;
            // 
            // desaparecidoBindingSource
            // 
            this.desaparecidoBindingSource.DataMember = "Entrevistado_Desaparecido";
            this.desaparecidoBindingSource.DataSource = this.entrevistadoBindingSource;
            // 
            // desaparecidoTableAdapter
            // 
            this.desaparecidoTableAdapter.ClearBeforeFill = true;
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
            this.desaparecidoDataGridView.Location = new System.Drawing.Point(38, 202);
            this.desaparecidoDataGridView.Name = "desaparecidoDataGridView";
            this.desaparecidoDataGridView.Size = new System.Drawing.Size(546, 220);
            this.desaparecidoDataGridView.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Volver al menú principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDesaparecido";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDesaparecido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desaparecidoDataGridView);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoComboBox);
            this.Controls.Add(fechaEntrevistaLabel);
            this.Controls.Add(this.fechaEntrevistaDateTimePicker);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(this.entrevistadoBindingNavigator);
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingNavigator)).EndInit();
            this.entrevistadoBindingNavigator.ResumeLayout(false);
            this.entrevistadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BusquedaDataSet busquedaDataSet;
        private System.Windows.Forms.BindingSource entrevistadoBindingSource;
        private BusquedaDataSetTableAdapters.EntrevistadoTableAdapter entrevistadoTableAdapter;
        private BusquedaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator entrevistadoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton entrevistadoBindingNavigatorSaveItem;
        private BusquedaDataSetTableAdapters.DesaparecidoTableAdapter desaparecidoTableAdapter;
        private System.Windows.Forms.ComboBox nombreCompletoComboBox;
        private System.Windows.Forms.DateTimePicker fechaEntrevistaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.BindingSource desaparecidoBindingSource;
        private System.Windows.Forms.DataGridView desaparecidoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}