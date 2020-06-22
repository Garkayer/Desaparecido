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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Desaparecido Desaparecido = new Desaparecido();
            Desaparecido.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Entrevistado Entrevistado = new Entrevistado();
            Entrevistado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Principal.Hide();
            Control Control = new Control();
            Control.Show();
        }
    }
}
