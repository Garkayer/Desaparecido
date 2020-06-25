namespace WindowsFormsApp1
{
    partial class UltimaVez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UltimaVez));
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ultimaVezLabel;
            System.Windows.Forms.Label nombreLabel;
            this.registroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.registroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.telefonoComboBox = new System.Windows.Forms.ComboBox();
            this.ultimaVezComboBox = new System.Windows.Forms.ComboBox();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.desaparecidoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desaparecidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busquedaDataSet1 = new WindowsFormsApp1.BusquedaDataSet1();
            this.registroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroTableAdapter = new WindowsFormsApp1.BusquedaDataSet1TableAdapters.RegistroTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.BusquedaDataSet1TableAdapters.TableAdapterManager();
            this.desaparecidoTableAdapter = new WindowsFormsApp1.BusquedaDataSet1TableAdapters.DesaparecidoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            telefonoLabel = new System.Windows.Forms.Label();
            ultimaVezLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingNavigator)).BeginInit();
            this.registroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registroBindingNavigator
            // 
            this.registroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registroBindingNavigator.BindingSource = this.registroBindingSource;
            this.registroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registroBindingNavigatorSaveItem});
            this.registroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registroBindingNavigator.Name = "registroBindingNavigator";
            this.registroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registroBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.registroBindingNavigator.TabIndex = 0;
            this.registroBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // registroBindingNavigatorSaveItem
            // 
            this.registroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registroBindingNavigatorSaveItem.Image")));
            this.registroBindingNavigatorSaveItem.Name = "registroBindingNavigatorSaveItem";
            this.registroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.registroBindingNavigatorSaveItem.Text = "Guardar datos";
            this.registroBindingNavigatorSaveItem.Click += new System.EventHandler(this.registroBindingNavigatorSaveItem_Click_1);
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(35, 104);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 3;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoComboBox
            // 
            this.telefonoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroBindingSource, "Telefono", true));
            this.telefonoComboBox.FormattingEnabled = true;
            this.telefonoComboBox.Location = new System.Drawing.Point(102, 101);
            this.telefonoComboBox.Name = "telefonoComboBox";
            this.telefonoComboBox.Size = new System.Drawing.Size(121, 21);
            this.telefonoComboBox.TabIndex = 4;
            // 
            // ultimaVezLabel
            // 
            ultimaVezLabel.AutoSize = true;
            ultimaVezLabel.Location = new System.Drawing.Point(35, 131);
            ultimaVezLabel.Name = "ultimaVezLabel";
            ultimaVezLabel.Size = new System.Drawing.Size(60, 13);
            ultimaVezLabel.TabIndex = 5;
            ultimaVezLabel.Text = "Ultima Vez:";
            // 
            // ultimaVezComboBox
            // 
            this.ultimaVezComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroBindingSource, "UltimaVez", true));
            this.ultimaVezComboBox.FormattingEnabled = true;
            this.ultimaVezComboBox.Location = new System.Drawing.Point(102, 128);
            this.ultimaVezComboBox.Name = "ultimaVezComboBox";
            this.ultimaVezComboBox.Size = new System.Drawing.Size(121, 21);
            this.ultimaVezComboBox.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(40, 71);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroBindingSource, "Nombre", true));
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(102, 71);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(121, 21);
            this.nombreComboBox.TabIndex = 8;
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
            this.desaparecidoDataGridView.Location = new System.Drawing.Point(38, 208);
            this.desaparecidoDataGridView.Name = "desaparecidoDataGridView";
            this.desaparecidoDataGridView.Size = new System.Drawing.Size(496, 220);
            this.desaparecidoDataGridView.TabIndex = 9;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
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
            this.dataGridViewTextBoxColumn5.HeaderText = "Preferencia Sexual";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha de nacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de nacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // desaparecidoBindingSource
            // 
            this.desaparecidoBindingSource.DataMember = "Desaparecido";
            this.desaparecidoBindingSource.DataSource = this.busquedaDataSet1;
            // 
            // busquedaDataSet1
            // 
            this.busquedaDataSet1.DataSetName = "BusquedaDataSet1";
            this.busquedaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroBindingSource
            // 
            this.registroBindingSource.DataMember = "Registro";
            this.registroBindingSource.DataSource = this.busquedaDataSet1;
            // 
            // registroTableAdapter
            // 
            this.registroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DesaparecidoTableAdapter = this.desaparecidoTableAdapter;
            this.tableAdapterManager.RegistroTableAdapter = this.registroTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.BusquedaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // desaparecidoTableAdapter
            // 
            this.desaparecidoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(654, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 94);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UltimaVez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desaparecidoDataGridView);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoComboBox);
            this.Controls.Add(ultimaVezLabel);
            this.Controls.Add(this.ultimaVezComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(this.registroBindingNavigator);
            this.Name = "UltimaVez";
            this.Text = "UltimaVez";
            this.Load += new System.EventHandler(this.UltimaVez_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingNavigator)).EndInit();
            this.registroBindingNavigator.ResumeLayout(false);
            this.registroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desaparecidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BusquedaDataSet1 busquedaDataSet1;
        private System.Windows.Forms.BindingSource registroBindingSource;
        private BusquedaDataSet1TableAdapters.RegistroTableAdapter registroTableAdapter;
        private BusquedaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registroBindingNavigatorSaveItem;
        private BusquedaDataSet1TableAdapters.DesaparecidoTableAdapter desaparecidoTableAdapter;
        private System.Windows.Forms.ComboBox telefonoComboBox;
        private System.Windows.Forms.ComboBox ultimaVezComboBox;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.BindingSource desaparecidoBindingSource;
        private System.Windows.Forms.DataGridView desaparecidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}