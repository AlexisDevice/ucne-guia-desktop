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
    public partial class profesor : Form
    {
        public profesor()
        {
            InitializeComponent();
        }

        private async void profesor_Load(object sender, EventArgs e)
        {
            ProfesorController profesor = new ProfesorController();
            profesoresgri.DataSource = await profesor.GetProfesores();
        }
    }
}
