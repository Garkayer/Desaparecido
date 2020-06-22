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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void entrevistadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entrevistadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busquedaDataSet);

        }

        private void entrevistadoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.entrevistadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busquedaDataSet);

        }

        private void Control_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'busquedaDataSet.Desaparecido' Puede moverla o quitarla según sea necesario.
            this.desaparecidoTableAdapter.Fill(this.busquedaDataSet.Desaparecido);
            // TODO: esta línea de código carga datos en la tabla 'busquedaDataSet.Entrevistado' Puede moverla o quitarla según sea necesario.
            this.entrevistadoTableAdapter.Fill(this.busquedaDataSet.Entrevistado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Principal Principal = new Principal();
            Principal.Show();
        }

        private void entrevistadoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }
    }
}
