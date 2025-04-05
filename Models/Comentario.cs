using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucne_guia_desktop.Models
{
    internal class Comentario
    {
        public int id { get; set; }
        public string contenido { get; set; }
        public string m_nombre { get; set; }
        public string u_nombre { get; set; }
        public string matricula { get; set; }

        public Comentario(int id, string contenido, string m_nombre, string u_nombre, string matricula)
        {
            this.id = id;
            this.contenido = contenido;
            this.m_nombre = m_nombre;
            this.u_nombre = u_nombre;
            this.matricula = matricula;
        }
    }
}
