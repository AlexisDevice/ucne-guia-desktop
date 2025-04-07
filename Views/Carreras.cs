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
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
        }

        private async void Carreras_Load(object sender, EventArgs e)
        {
            CarreraController carrera = new CarreraController();
            Carreragril.DataSource = await carrera.GetCarreras();
        }
    }
}
