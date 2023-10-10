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
    public partial class formBuscarAlumno : Form
    {
        public formBuscarAlumno()
        {
            InitializeComponent();
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();

            
            if (nombre != null)
            {
                try
                {
                    
                    string path = "E:\\FormProyectoPersona\\ProyectoFormPersonaAlumno\\Alumno.txt";

                    
                    string[] lineas = File.ReadAllLines(path);

                   
                    List<string> resultados = new List<string>();

                    
                    foreach (string linea in lineas)
                    {
                        
                        if (linea.Contains(nombre))
                        {
                           
                            resultados.Add(linea);
                        }
                    }

                    
                    lstBoxAlumno.DataSource = resultados;

                    if (resultados.Count == 0)
                    {
                        MessageBox.Show("La busqueda no arrojo resultados");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar en el archivo.");
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un término de búsqueda correcto.");
            }
        }
    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
        
  
