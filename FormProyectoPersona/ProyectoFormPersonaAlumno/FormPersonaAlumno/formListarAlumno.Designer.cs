namespace FormPersonaAlumno
{
    partial class formListarAlumno
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
            this.alumnoLstBox = new System.Windows.Forms.ListBox();
            this.alumnoMostrarLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alumnoLstBox
            // 
            this.alumnoLstBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.alumnoLstBox.FormattingEnabled = true;
            this.alumnoLstBox.Location = new System.Drawing.Point(178, 54);
            this.alumnoLstBox.Name = "alumnoLstBox";
            this.alumnoLstBox.Size = new System.Drawing.Size(424, 368);
            this.alumnoLstBox.TabIndex = 0;
            this.alumnoLstBox.SelectedIndexChanged += new System.EventHandler(this.alumnoLstBox_SelectedIndexChanged);
            // 
            // alumnoMostrarLbl
            // 
            this.alumnoMostrarLbl.AutoSize = true;
            this.alumnoMostrarLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnoMostrarLbl.Location = new System.Drawing.Point(333, 9);
            this.alumnoMostrarLbl.Name = "alumnoMostrarLbl";
            this.alumnoMostrarLbl.Size = new System.Drawing.Size(78, 20);
            this.alumnoMostrarLbl.TabIndex = 1;
            this.alumnoMostrarLbl.Text = "Alumnos";
            // 
            // formListarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alumnoMostrarLbl);
            this.Controls.Add(this.alumnoLstBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formListarAlumno";
            this.Text = "formListarAlumno";
            this.Load += new System.EventHandler(this.formListarAlumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox alumnoLstBox;
        private System.Windows.Forms.Label alumnoMostrarLbl;
    }
}