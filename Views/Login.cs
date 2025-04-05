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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            Signup ventana = new Signup();
            ventana.Owner = this;
            ventana.Show();
            this.Hide();
        }

        private async void Signin_btn_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            string email = Email_tbx.Text;
            string password = Password_tbx.Text;

            if (email.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                bool isAuth = await auth.Login(email, password);
                if (isAuth)
                {
                    Home home = new Home();
                    home.Owner = this;
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesion, intentelo de nuevo");
                }
            }
        }
    }
}
