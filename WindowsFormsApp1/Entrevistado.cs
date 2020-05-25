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
    public partial class Entrevistado : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Entrevistado()
        {
            InitializeComponent();
        }

        private void Entrevistado_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["Entrevistado"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdEntrevistado"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblIdEntrevistado.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtNombreCompleto.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtFechaDeEntrevista.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtFechaDeNacimiento.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtPais.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Persona Entrevistada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Persona Entrevistada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Persona Entrevistada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {

            txtNombreCompleto.Text = "";
            txtFechaDeEntrevista.Text = "";
            txtFechaDeNacimiento.Text = "";
            txtPais.Text = "";

        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btnEliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosEntrevistado.Enabled = !valor;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {//boton de nuevo
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {
                    lblIdEntrevistado.Text,
                    txtNombreCompleto.Text,
                    txtFechaDeEntrevista.Text,
                    txtFechaDeNacimiento.Text,
                    txtPais.Text,
                };
                objConexion.mantenimiento_datos(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {//boton de modificar
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreCompleto.Text, "Registro de personas entrevistadas",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblIdEntrevistado.Text };
                objConexion.mantenimiento_datos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaEntrevistado frmBusquedaEntrevistados = new BusquedaEntrevistado();
            frmBusquedaEntrevistados.ShowDialog();

            if (frmBusquedaEntrevistados._IdEntrevistado > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaEntrevistados._IdEntrevistado));
                mostrarDatos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Principal Principal = new Principal();
            Principal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Desaparecido Desaparecido = new Desaparecido();
            Desaparecido.Show();
        }
    }
}

