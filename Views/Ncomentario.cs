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

namespace ucne_guia_desktop.Views
{
    public partial class Ncomentario : Form
    {
        public Ncomentario()
        
        {
            InitializeComponent();
        }

        private async void Guardar_btn_Click(object sender, EventArgs e)
        {
            ComentariosController controller = new ComentariosController();
            string materiaId = MateriaId_tbx.Text;
            string contenido = Comentario_tbx.Text;
            bool isDone = await controller.postComentario(contenido, materiaId);
            if (isDone)
            {
                MessageBox.Show("Comentario creado exitosamente");
            }
            else
            {
                MessageBox.Show("No se pudo crear el comentario, intente de nuevo");
            }
        }
    }
}
