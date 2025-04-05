using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucne_guia_desktop.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Comentarios_btn_Click(object sender, EventArgs e)
        {
            Comentarios comentarios = new Comentarios();
            comentarios.Show();
        }

        private void Perfil_btn_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Materias_btn_Click(object sender, EventArgs e)
        {
            Materias materias = new Materias();
            materias.Show();
        }
    }
}
