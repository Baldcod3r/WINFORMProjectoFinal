using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPersonaAlumno
{
    public partial class panelContenedor : Form
    {
        public panelContenedor()
        {
            InitializeComponent();
        }


        
        public void formMenu_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (SubmenuReportes.Visible == false)
            { 
                SubmenuReportes.Visible = true; 
            }
                
            else
            {
                SubmenuReportes.Visible = false;
            }
            
        }

        private void btnCrearAutos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new formAlumno());

        }

        private void AbrirFormEnPanel(Form formhija)
        {
            if (this.panelAlumno.Controls.Count > 0)            
                this.panelAlumno.Controls.RemoveAt(0);         

            formhija.TopLevel = false;                           
            formhija.Dock = DockStyle.Fill;                     
            this.panelAlumno.Controls.Add(formhija);        
            this.panelAlumno.Tag = formhija;                
            formhija.Show();                                    


        }

        private void btnMostrarAutos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new formListarAlumno());
        }

        private void btnEliminarAutos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new formEliminar());
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formAlumno());
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formListarAlumno());
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formBuscarAlumno());
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new formEliminar());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscarAutos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new formBuscarAlumno());
        }

        private void minimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizarBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
