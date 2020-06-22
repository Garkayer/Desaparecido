using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void desaparecidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.desaparecidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busquedaDataSet);

        }

        private void desaparecidoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.desaparecidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busquedaDataSet);

        }

        private void Master_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'busquedaDataSet.Entrevistado' Puede moverla o quitarla según sea necesario.
            this.entrevistadoTableAdapter.Fill(this.busquedaDataSet.Entrevistado);
            // TODO: esta línea de código carga datos en la tabla 'busquedaDataSet.Desaparecido' Puede moverla o quitarla según sea necesario.
            this.desaparecidoTableAdapter.Fill(this.busquedaDataSet.Desaparecido);

        }

        private void entrevistadoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Principal Principal = new Principal();
            Principal.Show();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {

        }
    }
}
