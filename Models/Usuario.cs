using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucne_guia_desktop.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string matricula { get; set; }
        public string email { get; set; }

        public Usuario(string nombre, string matricula, string email)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.email = email;
        }
    }
}
