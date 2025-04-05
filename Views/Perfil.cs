using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ucne_guia_desktop.Controllers;
using ucne_guia_desktop.Models;

namespace ucne_guia_desktop.Views
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private async void Perfil_Load(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            Usuario user = await auth.getUsuario(Properties.Settings.Default.userId);
            Nombre_lb.Text = user.nombre;
            Matricula_lb.Text = user.matricula;
            Correo_lb.Text = user.email;
        }
    }
}
