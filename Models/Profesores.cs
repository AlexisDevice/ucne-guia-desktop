using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucne_guia_desktop.Models
{
    internal class Profesor
    {
        public int profesorId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }

        public Profesor(int profesorId, string nombre, string apellido, string correo)
        {
            this.profesorId = profesorId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
        }
    }
}
