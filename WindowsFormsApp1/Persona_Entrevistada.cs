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
    public partial class Persona_Entrevistada : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _IdEntrevistado;

        public Persona_Entrevistada()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdPersonaEntrevistada.RowCount > 0)
            {
                _IdEntrevistado = int.Parse(grdPersonaEntrevistada.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Entrevistado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void busqueda_clientes_Load(object sender, EventArgs e)
        {
            grdPersonaEntrevistada.DataSource =
               objConexion.obtener_datos().Tables["Entrevistado"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdPersonaEntrevistada.DataSource;
            bs.Filter = "nombre like '%" + valor + "%'";
            grdPersonaEntrevistada.DataSource = bs;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GrdBusquedaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
