using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucne_guia_desktop.Models
{
   internal class Materia
    {
        public int carreraId { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public int materiaId { get; set; }
        public int profesorId { get; set; }



        public Materia(int carreraId, string codigo, string nombre, int materiaId , int profesorId)
        {
            this.carreraId = carreraId;
            this.codigo = codigo;
            this.nombre = nombre;
            this.materiaId = materiaId;
            this.profesorId = profesorId;

        }
    }

   
}
