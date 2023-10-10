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
    public partial class formAlumno : Form
    {
        List  <Alumno> alumnoList = new List<Alumno>();
        public formAlumno()
        {
            InitializeComponent();
        }


        
private void agregarAlumnoBtn_Click(object sender, EventArgs e)
        {

            try
            {
                eliminarSelecBtn.Enabled = true;
                guardarEnArchivoBtn.Enabled = true;


                string nombre = nombreTxtBox.Text;
                string apellido = apellidoTxtBox.Text;
                string dni = dniTxtBox.Text;
                string cuil = cuilTxtBox.Text;
                string carrera = carreraTxtBox.Text;
                int materias = int.Parse(materiasTxtBox.Text);
                bool estado;
                if (estadoCmb.Text == "Si")
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }

                bool inscripto;
                if (inscriptoCmb.Text == "Si")
                {
                    inscripto = true;
                }
                else
                {
                    inscripto = false;
                }

                bool adeuda;
                if (adeudaCmb.Text == "Si")
                {
                    adeuda = true;
                }
                else
                {
                    adeuda = false;
                }

                alumnoList.Add(new Alumno() { Nombre = nombre, Apellido = apellido, Dni = dni, Cuil = cuil, Carrera = carrera, CantidadDeMaterias = materias, Estado = estado, Inscripto = inscripto, AdeudaDocumentacion = adeuda, });
                alumnoLstBox.Items.Add(nombre + "-" + apellido + "-" + dni + "-" + cuil + "-" + estado + "-" + inscripto + "-" + adeuda);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Alguno de los datos ingresados no corresponde con los datos solicitados");
                MessageBox.Show(ex.Message, "Error");

            }
           
            finally
            {
                LimpiarFormulario();
            }


        }


        

        private void LimpiarFormulario()
        {
            nombreTxtBox.Text = "";
            apellidoTxtBox.Text = "";
            dniTxtBox.Text = "";
            cuilTxtBox.Text = "";
            estadoCmb.Text = "";
            inscriptoCmb.Text = "";
            adeudaCmb.Text = "";
            materiasTxtBox.Text = "";
            carreraTxtBox.Text = "";
        }

        private void eliminarSelecBtn_Click(object sender, EventArgs e)
        {
            int indexLista = alumnoLstBox.SelectedIndex;
            alumnoList.RemoveAt(indexLista);
            alumnoLstBox.Items.Remove(alumnoLstBox.SelectedItem);
        }

        private void salirSinGuardarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarEnArchivoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "E:\\FormProyectoPersona\\ProyectoFormPersonaAlumno\\Alumno.txt";
                StreamWriter archivo;
                if (File.Exists(path))
                {
                    //MODIFICA EL ARCHIVO EXISTENTE

                    archivo = File.AppendText(path);
                }
                else
                {
                    //CREAR UN ARCHIVO 

                    archivo = File.CreateText(path);
                }
                foreach (Alumno a in alumnoList)
                {
                    archivo.Write($"{a.Nombre} - ");
                    archivo.Write($"{a.Apellido} - ");
                    archivo.Write($"{a.Dni} - ");
                    archivo.Write($"{a.Cuil} - ");
                    archivo.Write($"{a.Carrera}  - ");
                    archivo.Write($"{a.CantidadDeMaterias} - ");
                    archivo.Write($"{a.Estado}  - ");
                    archivo.Write($"{a.AdeudaDocumentacion}  - ");
                    archivo.Write($"{a.Inscripto} - ");
                    archivo.Write($"{DateTime.Now.ToShortTimeString()}");

                    archivo.Write("\n*");


                }
                archivo.Close();
                MessageBox.Show("El archivo se guardó correctamente", "Confirmación");
            }

            catch (Exception ex)
            {
                MessageBox.Show("La ruta especificada no existe", "Error");
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.Close();
            }


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
