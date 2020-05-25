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
    public partial class BusquedaDesaparecido : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _IdDesaparecido;
        public BusquedaDesaparecido()
        {
            InitializeComponent();
        }

        private void BusquedaDesaparecido_Load(object sender, EventArgs e)
        {
            grdBusquedaDesaparecido.DataSource = objConexion.obtener_datos().Tables["Desaparecido"].DefaultView;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaDesaparecido.RowCount > 0)
            {
                _IdDesaparecido = int.Parse(grdBusquedaDesaparecido.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de desaparecidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           

        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaDesaparecido.DataSource;
            bs.Filter = "nombre like '%" + valor + "%'";
            grdBusquedaDesaparecido.DataSource = bs;
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
