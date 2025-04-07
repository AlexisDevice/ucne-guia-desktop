using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucne_guia_desktop.Models
{
    class Carrera
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Carrera(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
