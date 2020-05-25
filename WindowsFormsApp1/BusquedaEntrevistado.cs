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
    public partial class BusquedaEntrevistado : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _IdEntrevistado;
        public BusquedaEntrevistado()
        {
            InitializeComponent();
        }

        private void grdBusquedaAlquiler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BusquedaEntrevistado_Load(object sender, EventArgs e)
        {
            grdBusquedaEntrevistado.DataSource = objConexion.obtener_datos().Tables["Entrevistado"].DefaultView;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaEntrevistado.RowCount > 0)
            {
                _IdEntrevistado = int.Parse(grdBusquedaEntrevistado.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaEntrevistado.DataSource;
            bs.Filter = "nombre like '%" + valor + "%'";
            grdBusquedaEntrevistado.DataSource = bs;
        }

        private void lblbuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
