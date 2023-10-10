namespace FormPersonaAlumno
{
    partial class formAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlumno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.materiasTxtBox = new System.Windows.Forms.TextBox();
            this.inscriptoCmb = new System.Windows.Forms.ComboBox();
            this.adeudaCmb = new System.Windows.Forms.ComboBox();
            this.estadoCmb = new System.Windows.Forms.ComboBox();
            this.inscriptoLbl = new System.Windows.Forms.Label();
            this.carreraTxtBox = new System.Windows.Forms.TextBox();
            this.materiaLbl = new System.Windows.Forms.Label();
            this.cuilTxtBox = new System.Windows.Forms.TextBox();
            this.dniTxtBox = new System.Windows.Forms.TextBox();
            this.cuilLbl = new System.Windows.Forms.Label();
            this.dniLbl = new System.Windows.Forms.Label();
            this.apellidoTxtBox = new System.Windows.Forms.TextBox();
            this.nombreTxtBox = new System.Windows.Forms.TextBox();
            this.carreraLbl = new System.Windows.Forms.Label();
            this.estadoLbl = new System.Windows.Forms.Label();
            this.adeudaLbl = new System.Windows.Forms.Label();
            this.apellidoLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.cancelarAlumnoBtn = new System.Windows.Forms.Button();
            this.agregarAlumnoBtn = new System.Windows.Forms.Button();
            this.alumnoLstBox = new System.Windows.Forms.ListBox();
            this.salirSinGuardarBtn = new System.Windows.Forms.Button();
            this.eliminarSelecBtn = new System.Windows.Forms.Button();
            this.guardarEnArchivoBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.materiasTxtBox);
            this.groupBox1.Controls.Add(this.inscriptoCmb);
            this.groupBox1.Controls.Add(this.adeudaCmb);
            this.groupBox1.Controls.Add(this.estadoCmb);
            this.groupBox1.Controls.Add(this.inscriptoLbl);
            this.groupBox1.Controls.Add(this.carreraTxtBox);
            this.groupBox1.Controls.Add(this.materiaLbl);
            this.groupBox1.Controls.Add(this.cuilTxtBox);
            this.groupBox1.Controls.Add(this.dniTxtBox);
            this.groupBox1.Controls.Add(this.cuilLbl);
            this.groupBox1.Controls.Add(this.dniLbl);
            this.groupBox1.Controls.Add(this.apellidoTxtBox);
            this.groupBox1.Controls.Add(this.nombreTxtBox);
            this.groupBox1.Controls.Add(this.carreraLbl);
            this.groupBox1.Controls.Add(this.estadoLbl);
            this.groupBox1.Controls.Add(this.adeudaLbl);
            this.groupBox1.Controls.Add(this.apellidoLbl);
            this.groupBox1.Controls.Add(this.nombreLbl);
            this.groupBox1.Controls.Add(this.cancelarAlumnoBtn);
            this.groupBox1.Controls.Add(this.agregarAlumnoBtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(28, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 493);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Alumno";
            // 
            // clearBtn
            // 
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn.Location = new System.Drawing.Point(224, 183);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(58, 34);
            this.clearBtn.TabIndex = 27;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // materiasTxtBox
            // 
            this.materiasTxtBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.materiasTxtBox.Location = new System.Drawing.Point(89, 213);
            this.materiasTxtBox.Name = "materiasTxtBox";
            this.materiasTxtBox.Size = new System.Drawing.Size(100, 20);
            this.materiasTxtBox.TabIndex = 26;
            // 
            // inscriptoCmb
            // 
            this.inscriptoCmb.BackColor = System.Drawing.SystemColors.Highlight;
            this.inscriptoCmb.FormattingEnabled = true;
            this.inscriptoCmb.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.inscriptoCmb.Location = new System.Drawing.Point(151, 305);
            this.inscriptoCmb.Name = "inscriptoCmb";
            this.inscriptoCmb.Size = new System.Drawing.Size(38, 21);
            this.inscriptoCmb.TabIndex = 25;
            // 
            // adeudaCmb
            // 
            this.adeudaCmb.BackColor = System.Drawing.SystemColors.Highlight;
            this.adeudaCmb.FormattingEnabled = true;
            this.adeudaCmb.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.adeudaCmb.Location = new System.Drawing.Point(151, 274);
            this.adeudaCmb.Name = "adeudaCmb";
            this.adeudaCmb.Size = new System.Drawing.Size(38, 21);
            this.adeudaCmb.TabIndex = 24;
            // 
            // estadoCmb
            // 
            this.estadoCmb.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.estadoCmb.FormattingEnabled = true;
            this.estadoCmb.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.estadoCmb.Location = new System.Drawing.Point(151, 243);
            this.estadoCmb.Name = "estadoCmb";
            this.estadoCmb.Size = new System.Drawing.Size(38, 21);
            this.estadoCmb.TabIndex = 23;
            // 
            // inscriptoLbl
            // 
            this.inscriptoLbl.AutoSize = true;
            this.inscriptoLbl.Location = new System.Drawing.Point(28, 305);
            this.inscriptoLbl.Name = "inscriptoLbl";
            this.inscriptoLbl.Size = new System.Drawing.Size(47, 13);
            this.inscriptoLbl.TabIndex = 19;
            this.inscriptoLbl.Text = "Inscripto";
            // 
            // carreraTxtBox
            // 
            this.carreraTxtBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.carreraTxtBox.Location = new System.Drawing.Point(89, 183);
            this.carreraTxtBox.Name = "carreraTxtBox";
            this.carreraTxtBox.Size = new System.Drawing.Size(100, 20);
            this.carreraTxtBox.TabIndex = 17;
            // 
            // materiaLbl
            // 
            this.materiaLbl.AutoSize = true;
            this.materiaLbl.Location = new System.Drawing.Point(25, 216);
            this.materiaLbl.Name = "materiaLbl";
            this.materiaLbl.Size = new System.Drawing.Size(47, 13);
            this.materiaLbl.TabIndex = 14;
            this.materiaLbl.Text = "Materias";
            // 
            // cuilTxtBox
            // 
            this.cuilTxtBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.cuilTxtBox.Location = new System.Drawing.Point(89, 157);
            this.cuilTxtBox.Name = "cuilTxtBox";
            this.cuilTxtBox.Size = new System.Drawing.Size(100, 20);
            this.cuilTxtBox.TabIndex = 13;
            // 
            // dniTxtBox
            // 
            this.dniTxtBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.dniTxtBox.Location = new System.Drawing.Point(89, 127);
            this.dniTxtBox.Name = "dniTxtBox";
            this.dniTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dniTxtBox.TabIndex = 12;
            // 
            // cuilLbl
            // 
            this.cuilLbl.AutoSize = true;
            this.cuilLbl.Location = new System.Drawing.Point(28, 160);
            this.cuilLbl.Name = "cuilLbl";
            this.cuilLbl.Size = new System.Drawing.Size(24, 13);
            this.cuilLbl.TabIndex = 11;
            this.cuilLbl.Text = "Cuil";
            // 
            // dniLbl
            // 
            this.dniLbl.AutoSize = true;
            this.dniLbl.Location = new System.Drawing.Point(29, 134);
            this.dniLbl.Name = "dniLbl";
            this.dniLbl.Size = new System.Drawing.Size(23, 13);
            this.dniLbl.TabIndex = 10;
            this.dniLbl.Text = "Dni";
            // 
            // apellidoTxtBox
            // 
            this.apellidoTxtBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.apellidoTxtBox.Location = new System.Drawing.Point(89, 101);
            this.apellidoTxtBox.Name = "apellidoTxtBox";
            this.apellidoTxtBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTxtBox.TabIndex = 9;
            // 
            // nombreTxtBox
            // 
            this.nombreTxtBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.nombreTxtBox.Location = new System.Drawing.Point(89, 74);
            this.nombreTxtBox.Name = "nombreTxtBox";
            this.nombreTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTxtBox.TabIndex = 8;
            // 
            // carreraLbl
            // 
            this.carreraLbl.AutoSize = true;
            this.carreraLbl.Location = new System.Drawing.Point(25, 188);
            this.carreraLbl.Name = "carreraLbl";
            this.carreraLbl.Size = new System.Drawing.Size(41, 13);
            this.carreraLbl.TabIndex = 7;
            this.carreraLbl.Text = "Carrera";
            // 
            // estadoLbl
            // 
            this.estadoLbl.AutoSize = true;
            this.estadoLbl.Location = new System.Drawing.Point(23, 243);
            this.estadoLbl.Name = "estadoLbl";
            this.estadoLbl.Size = new System.Drawing.Size(40, 13);
            this.estadoLbl.TabIndex = 6;
            this.estadoLbl.Text = "Estado";
            // 
            // adeudaLbl
            // 
            this.adeudaLbl.AutoSize = true;
            this.adeudaLbl.Location = new System.Drawing.Point(23, 277);
            this.adeudaLbl.Name = "adeudaLbl";
            this.adeudaLbl.Size = new System.Drawing.Size(122, 13);
            this.adeudaLbl.TabIndex = 5;
            this.adeudaLbl.Text = "Adeuda Documentacion";
            // 
            // apellidoLbl
            // 
            this.apellidoLbl.AutoSize = true;
            this.apellidoLbl.Location = new System.Drawing.Point(28, 110);
            this.apellidoLbl.Name = "apellidoLbl";
            this.apellidoLbl.Size = new System.Drawing.Size(44, 13);
            this.apellidoLbl.TabIndex = 4;
            this.apellidoLbl.Text = "Apellido";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(29, 81);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreLbl.TabIndex = 3;
            this.nombreLbl.Text = "Nombre";
            // 
            // cancelarAlumnoBtn
            // 
            this.cancelarAlumnoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cancelarAlumnoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarAlumnoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cancelarAlumnoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarAlumnoBtn.Location = new System.Drawing.Point(151, 440);
            this.cancelarAlumnoBtn.Name = "cancelarAlumnoBtn";
            this.cancelarAlumnoBtn.Size = new System.Drawing.Size(109, 47);
            this.cancelarAlumnoBtn.TabIndex = 2;
            this.cancelarAlumnoBtn.Text = "Cancelar";
            this.cancelarAlumnoBtn.UseVisualStyleBackColor = true;
            // 
            // agregarAlumnoBtn
            // 
            this.agregarAlumnoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarAlumnoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.agregarAlumnoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarAlumnoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.agregarAlumnoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.agregarAlumnoBtn.Location = new System.Drawing.Point(21, 440);
            this.agregarAlumnoBtn.Name = "agregarAlumnoBtn";
            this.agregarAlumnoBtn.Size = new System.Drawing.Size(106, 47);
            this.agregarAlumnoBtn.TabIndex = 1;
            this.agregarAlumnoBtn.Text = "Agregar";
            this.agregarAlumnoBtn.UseVisualStyleBackColor = true;
            this.agregarAlumnoBtn.Click += new System.EventHandler(this.agregarAlumnoBtn_Click);
            // 
            // alumnoLstBox
            // 
            this.alumnoLstBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.alumnoLstBox.FormattingEnabled = true;
            this.alumnoLstBox.Location = new System.Drawing.Point(376, 42);
            this.alumnoLstBox.Name = "alumnoLstBox";
            this.alumnoLstBox.Size = new System.Drawing.Size(406, 485);
            this.alumnoLstBox.TabIndex = 1;
            // 
            // salirSinGuardarBtn
            // 
            this.salirSinGuardarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.salirSinGuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirSinGuardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.salirSinGuardarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salirSinGuardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("salirSinGuardarBtn.Image")));
            this.salirSinGuardarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirSinGuardarBtn.Location = new System.Drawing.Point(806, 260);
            this.salirSinGuardarBtn.Name = "salirSinGuardarBtn";
            this.salirSinGuardarBtn.Size = new System.Drawing.Size(222, 47);
            this.salirSinGuardarBtn.TabIndex = 22;
            this.salirSinGuardarBtn.Text = "Salir sin Guardar";
            this.salirSinGuardarBtn.UseVisualStyleBackColor = true;
            this.salirSinGuardarBtn.Click += new System.EventHandler(this.salirSinGuardarBtn_Click);
            // 
            // eliminarSelecBtn
            // 
            this.eliminarSelecBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eliminarSelecBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.eliminarSelecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarSelecBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.eliminarSelecBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminarSelecBtn.Image = ((System.Drawing.Image)(resources.GetObject("eliminarSelecBtn.Image")));
            this.eliminarSelecBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.eliminarSelecBtn.Location = new System.Drawing.Point(806, 65);
            this.eliminarSelecBtn.Name = "eliminarSelecBtn";
            this.eliminarSelecBtn.Size = new System.Drawing.Size(222, 47);
            this.eliminarSelecBtn.TabIndex = 21;
            this.eliminarSelecBtn.Text = "Eliminar Seleccionado";
            this.eliminarSelecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarSelecBtn.UseVisualStyleBackColor = true;
            this.eliminarSelecBtn.Click += new System.EventHandler(this.eliminarSelecBtn_Click);
            // 
            // guardarEnArchivoBtn
            // 
            this.guardarEnArchivoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.guardarEnArchivoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarEnArchivoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.guardarEnArchivoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guardarEnArchivoBtn.Image = ((System.Drawing.Image)(resources.GetObject("guardarEnArchivoBtn.Image")));
            this.guardarEnArchivoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarEnArchivoBtn.Location = new System.Drawing.Point(806, 474);
            this.guardarEnArchivoBtn.Name = "guardarEnArchivoBtn";
            this.guardarEnArchivoBtn.Size = new System.Drawing.Size(222, 47);
            this.guardarEnArchivoBtn.TabIndex = 23;
            this.guardarEnArchivoBtn.Text = "Guardar en Archivo";
            this.guardarEnArchivoBtn.UseVisualStyleBackColor = true;
            this.guardarEnArchivoBtn.Click += new System.EventHandler(this.guardarEnArchivoBtn_Click);
            // 
            // formAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1080, 584);
            this.Controls.Add(this.guardarEnArchivoBtn);
            this.Controls.Add(this.salirSinGuardarBtn);
            this.Controls.Add(this.eliminarSelecBtn);
            this.Controls.Add(this.alumnoLstBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAlumno";
            this.Text = "formAlumno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox apellidoTxtBox;
        private System.Windows.Forms.TextBox nombreTxtBox;
        private System.Windows.Forms.Label carreraLbl;
        private System.Windows.Forms.Label estadoLbl;
        private System.Windows.Forms.Label adeudaLbl;
        private System.Windows.Forms.Label apellidoLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Button cancelarAlumnoBtn;
        private System.Windows.Forms.Button agregarAlumnoBtn;
        private System.Windows.Forms.TextBox cuilTxtBox;
        private System.Windows.Forms.TextBox dniTxtBox;
        private System.Windows.Forms.Label cuilLbl;
        private System.Windows.Forms.Label dniLbl;
        private System.Windows.Forms.Label materiaLbl;
        private System.Windows.Forms.TextBox carreraTxtBox;
        private System.Windows.Forms.Label inscriptoLbl;
        private System.Windows.Forms.ListBox alumnoLstBox;
        private System.Windows.Forms.Button salirSinGuardarBtn;
        private System.Windows.Forms.Button eliminarSelecBtn;
        private System.Windows.Forms.Button guardarEnArchivoBtn;
        private System.Windows.Forms.ComboBox inscriptoCmb;
        private System.Windows.Forms.ComboBox adeudaCmb;
        private System.Windows.Forms.ComboBox estadoCmb;
        private System.Windows.Forms.TextBox materiasTxtBox;
        private System.Windows.Forms.Button clearBtn;
    }
}