using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ucne_guia_desktop.Controllers;

namespace ucne_guia_desktop.Views
{
    public partial class Comentarios : Form
    {
        public Comentarios()
        {
            InitializeComponent();
        }

        private void NuevoComentario_btn_Click(object sender, EventArgs e)
        {
            Ncomentario ncomentario = new Ncomentario();
            ncomentario.Show();
        }

        private async void Comentarios_Load(object sender, EventArgs e)
        {
            ComentariosController comentarios = new ComentariosController();
            Comentarios_dtg.DataSource = await comentarios.getComentarios();
        }
    }
}
