using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPersonaAlumno
{
    public partial class formListarAlumno : Form
    {
        public formListarAlumno()
        {
            InitializeComponent();

        }

        private void alumnoLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }



        

        private void mostrarAlumnoBtn_Click(object sender, EventArgs e)
        {
            
        }


        public void MostrarContenidoArchivo(string nombreArchivo)
        {
            string path = "E:\\FormProyectoPersona\\ProyectoFormPersonaAlumno\\Alumno.txt";
            StreamReader archivoALeer = File.OpenText(path);
            string renglon = archivoALeer.ReadLine();

            do
            {
                alumnoLstBox.Items.Add(renglon);
                renglon = archivoALeer.ReadLine();

            } while (renglon != null);
            archivoALeer.Close();
        }

        private void formListarAlumno_Load(object sender, EventArgs e)
        {
            MostrarContenidoArchivo("Alumno.txt");
        }
    }
}
