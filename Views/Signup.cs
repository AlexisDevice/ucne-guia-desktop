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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private async void Signup_btn_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            string nombre = Nombre_tbx.Text;
            string matricula = Matricula_tbx.Text;
            string email = Email_tbx.Text;
            string password = password_tbx.Text;
            bool result = await auth.Signup(nombre, matricula, email, password);

            if (result)
            {
                MessageBox.Show("Nuevo usuario creado!");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion, trate de nuevo");
            }
        }
    }
}
