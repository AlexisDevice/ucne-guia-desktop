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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        private async void Materia_Load(object sender, EventArgs e)
        {
            MateriaController materia = new MateriaController();
            materiadatagri.DataSource = await materia.getmateria();
        }
    }
}
