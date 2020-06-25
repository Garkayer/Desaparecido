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
    public partial class UltimaVez : Form
    {
        public UltimaVez()
        {
            InitializeComponent();
        }

        private void registroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busquedaDataSet1);

        }

        private void registroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.registroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.busquedaDataSet1);

        }

        private void UltimaVez_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'busquedaDataSet1.Desaparecido' Puede moverla o quitarla según sea necesario.
            this.desaparecidoTableAdapter.Fill(this.busquedaDataSet1.Desaparecido);
            // TODO: esta línea de código carga datos en la tabla 'busquedaDataSet1.Registro' Puede moverla o quitarla según sea necesario.
            this.registroTableAdapter.Fill(this.busquedaDataSet1.Registro);

        }
    }
}
