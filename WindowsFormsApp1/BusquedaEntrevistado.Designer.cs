namespace WindowsFormsApp1
{
    partial class BusquedaEntrevistado
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
            this.grdBusquedaEntrevistado = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEntrevistado)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaEntrevistado
            // 
            this.grdBusquedaEntrevistado.AllowUserToAddRows = false;
            this.grdBusquedaEntrevistado.AllowUserToDeleteRows = false;
            this.grdBusquedaEntrevistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaEntrevistado.Location = new System.Drawing.Point(10, 36);
            this.grdBusquedaEntrevistado.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaEntrevistado.Name = "grdBusquedaEntrevistado";
            this.grdBusquedaEntrevistado.ReadOnly = true;
            this.grdBusquedaEntrevistado.RowHeadersWidth = 102;
            this.grdBusquedaEntrevistado.RowTemplate.Height = 40;
            this.grdBusquedaEntrevistado.Size = new System.Drawing.Size(623, 346);
            this.grdBusquedaEntrevistado.TabIndex = 12;
            this.grdBusquedaEntrevistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBusquedaAlquiler_CellContentClick);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(13, 400);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 17;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(118, 400);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // BusquedaEntrevistado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaEntrevistado);
            this.Name = "BusquedaEntrevistado";
            this.Text = "BusquedaEntrevistado";
            this.Load += new System.EventHandler(this.BusquedaEntrevistado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEntrevistado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaEntrevistado;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Button btncancelar;
    }
}