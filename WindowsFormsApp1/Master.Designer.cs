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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            System.Windows.Forms.Label nombreCompletoLabel;
            this.busquedaDataSet = new WindowsFormsApp1.BusquedaDataSet();
            this.desaparecidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desaparecidoTableAdapter = new WindowsFormsApp1.BusquedaDataSetTableAdapters.DesaparecidoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.BusquedaDataSetTableAdapters.TableAdapterManager();
            this.entrevistadoTableAdapter = new WindowsFormsApp1.BusquedaDataSetTableAdapters.EntrevistadoTableAdapter();
            this.desaparecidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.desaparecidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.entrevistadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrevistadoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreCompletoComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingNavigator)).BeginInit();
            this.desaparecidoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoDataGridView)).BeginInit();
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
            // desaparecidoBindingNavigator
            // 
            this.desaparecidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.desaparecidoBindingNavigator.BindingSource = this.desaparecidoBindingSource;
            this.desaparecidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.desaparecidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.desaparecidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.desaparecidoBindingNavigatorSaveItem});
            this.desaparecidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.desaparecidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.desaparecidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.desaparecidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.desaparecidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.desaparecidoBindingNavigator.Name = "desaparecidoBindingNavigator";
            this.desaparecidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.desaparecidoBindingNavigator.Size = new System.Drawing.Size(846, 25);
            this.desaparecidoBindingNavigator.TabIndex = 0;
            this.desaparecidoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // desaparecidoBindingNavigatorSaveItem
            // 
            this.desaparecidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.desaparecidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("desaparecidoBindingNavigatorSaveItem.Image")));
            this.desaparecidoBindingNavigatorSaveItem.Name = "desaparecidoBindingNavigatorSaveItem";
            this.desaparecidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.desaparecidoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.desaparecidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.desaparecidoBindingNavigatorSaveItem_Click_1);
            // 
            // entrevistadoBindingSource
            // 
            this.entrevistadoBindingSource.DataMember = "Entrevistado";
            this.entrevistadoBindingSource.DataSource = this.busquedaDataSet;
            // 
            // Pais
            // 
            this.Pais.DataPropertyName = "Pais";
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // FechaEntrevista
            // 
            this.FechaEntrevista.DataPropertyName = "FechaEntrevista";
            this.FechaEntrevista.HeaderText = "FechaEntrevista";
            this.FechaEntrevista.Name = "FechaEntrevista";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEntrevistado";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEntrevistado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // entrevistadoDataGridView
            // 
            this.entrevistadoDataGridView.AutoGenerateColumns = false;
            this.entrevistadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entrevistadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NombreCompleto,
            this.FechaEntrevista,
            this.FechaNacimiento,
            this.Pais});
            this.entrevistadoDataGridView.DataSource = this.entrevistadoBindingSource;
            this.entrevistadoDataGridView.Location = new System.Drawing.Point(27, 230);
            this.entrevistadoDataGridView.Name = "entrevistadoDataGridView";
            this.entrevistadoDataGridView.Size = new System.Drawing.Size(542, 220);
            this.entrevistadoDataGridView.TabIndex = 13;
            this.entrevistadoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entrevistadoDataGridView_CellContentClick);
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
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Location = new System.Drawing.Point(12, 51);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(181, 13);
            nombreCompletoLabel.TabIndex = 3;
            nombreCompletoLabel.Text = "Nombre de la persona desaparecida:";
            // 
            // nombreCompletoComboBox
            // 
            this.nombreCompletoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.desaparecidoBindingSource, "NombreCompleto", true));
            this.nombreCompletoComboBox.FormattingEnabled = true;
            this.nombreCompletoComboBox.Location = new System.Drawing.Point(199, 51);
            this.nombreCompletoComboBox.Name = "nombreCompletoComboBox";
            this.nombreCompletoComboBox.Size = new System.Drawing.Size(223, 21);
            this.nombreCompletoComboBox.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Características de la persona desaparecida";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 575);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entrevistadoDataGridView);
            this.Controls.Add(nombreCompletoLabel);
            this.Controls.Add(this.nombreCompletoComboBox);
            this.Controls.Add(this.desaparecidoBindingNavigator);
            this.Name = "Master";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingNavigator)).EndInit();
            this.desaparecidoBindingNavigator.ResumeLayout(false);
            this.desaparecidoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrevistadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BusquedaDataSet busquedaDataSet;
        private System.Windows.Forms.BindingSource desaparecidoBindingSource;
        private BusquedaDataSetTableAdapters.DesaparecidoTableAdapter desaparecidoTableAdapter;
        private BusquedaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator desaparecidoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton desaparecidoBindingNavigatorSaveItem;
        private BusquedaDataSetTableAdapters.EntrevistadoTableAdapter entrevistadoTableAdapter;
        private System.Windows.Forms.BindingSource entrevistadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView entrevistadoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox nombreCompletoComboBox;
        private System.Windows.Forms.Button button2;
    }
}