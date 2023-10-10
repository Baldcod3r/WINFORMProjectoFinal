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
    public partial class formEliminar : Form
    {
        List<Alumno> alumnoList = new List<Alumno>();
        public formEliminar()
        {
            InitializeComponent();
            MostrarContenidoArchivo("Alumno.txt");
        }

        /// <summary>
        /// Muestra el contenido de un archivo en un control ListBox.
        /// </summary>
        /// <param name="nombreArchivo">El nombre del archivo a mostrar.</param>
        public void MostrarContenidoArchivo(string nombreArchivo)
        {
            string path = "E:\\FormProyectoPersona\\ProyectoFormPersonaAlumno\\Alumno.txt";
            StreamReader archivoALeer = File.OpenText(path);
            string renglon = archivoALeer.ReadLine();

            do
            {
                alumnoEliminarLstBox.Items.Add(renglon);
                renglon = archivoALeer.ReadLine();

            } while (renglon != null);
            archivoALeer.Close();
        }




        /// <summary>
        /// Maneja el evento de clic en el botón para eliminar un alumno.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el botón).</param>
        /// <param name="e">Los datos del evento.</param>
        private void eliminarAlumnoBtn_Click(object sender, EventArgs e)
        {
            
            if (alumnoEliminarLstBox.SelectedIndex != -1)
            {
                
                string indiceAEliminar = alumnoEliminarLstBox.SelectedItem.ToString();

                
                EliminarIndiceDelArchivo(indiceAEliminar);

                
                CargarIndicesEnListBox();

                MessageBox.Show("Índice eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona un índice para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Carga los índices desde un archivo en un control ListBox.
        /// </summary>
        private void CargarIndicesEnListBox()
        {
            
            alumnoEliminarLstBox.Items.Clear();

            
            string rutaArchivo = "E:\\FormProyectoPersona\\ProyectoFormPersonaAlumno\\Alumno.txt";

           
            string[] indices = File.ReadAllLines(rutaArchivo);

            
            alumnoEliminarLstBox.Items.AddRange(indices);
        }


        /// <summary>
        /// Elimina un índice específico del contenido de un archivo.
        /// </summary>
        /// <param name="indice">El índice que se eliminará del archivo.</param>
        private void EliminarIndiceDelArchivo(string indice)
        {
            
            string rutaArchivo = "E:\\FormProyectoPersona\\ProyectoFormPersonaAlumno\\Alumno.txt";

            string[] indices = File.ReadAllLines(rutaArchivo);

            
            string[] nuevosIndices = Array.FindAll(indices, i => i != indice);

            File.WriteAllLines(rutaArchivo, nuevosIndices);
        }


        /// <summary>
        /// Maneja el evento de clic en el botón para cancelar la operación de eliminar.
        /// </summary>
        /// <param name="sender">El objeto que genera el evento (el botón).</param>
        /// <param name="e">Los datos del evento.</param>
        private void cancelarEliminarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
