using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnInstructivo_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form instructivo = new Instructivos();
            instructivo.Show();
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form autores = new Autores();
            autores.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form jugar = new Juego();
            jugar.Show();
        }
    }
}
