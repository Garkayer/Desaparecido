namespace WindowsFormsApp1
{
    partial class BusquedaDesaparecido
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
            this.grdBusquedaDesaparecido = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaDesaparecido)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaDesaparecido
            // 
            this.grdBusquedaDesaparecido.AllowUserToAddRows = false;
            this.grdBusquedaDesaparecido.AllowUserToDeleteRows = false;
            this.grdBusquedaDesaparecido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaDesaparecido.Location = new System.Drawing.Point(10, 38);
            this.grdBusquedaDesaparecido.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaDesaparecido.Name = "grdBusquedaDesaparecido";
            this.grdBusquedaDesaparecido.ReadOnly = true;
            this.grdBusquedaDesaparecido.RowHeadersWidth = 102;
            this.grdBusquedaDesaparecido.RowTemplate.Height = 40;
            this.grdBusquedaDesaparecido.Size = new System.Drawing.Size(623, 346);
            this.grdBusquedaDesaparecido.TabIndex = 13;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(10, 399);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 18;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(115, 399);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // BusquedaDesaparecido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaDesaparecido);
            this.Name = "BusquedaDesaparecido";
            this.Text = "BusquedaDesaparecido";
            this.Load += new System.EventHandler(this.BusquedaDesaparecido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaDesaparecido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBusquedaDesaparecido;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Button btncancelar;
    }
}