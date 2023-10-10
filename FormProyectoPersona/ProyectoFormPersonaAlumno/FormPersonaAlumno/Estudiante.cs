using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersonaAlumno
{
    public class Estudiante : Persona
    {
        private bool estado;
        private string carrera;


        public bool Estado { get => estado; set => estado = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public Estudiante()
        {

        }
        public Estudiante(int id, string nombre, string apellido, string dni, string cuil, bool estado, string carrera) : base(id, nombre, apellido, dni, cuil)
        {

            this.estado = true;
            this.carrera = string.Empty;
        }



    }
}
