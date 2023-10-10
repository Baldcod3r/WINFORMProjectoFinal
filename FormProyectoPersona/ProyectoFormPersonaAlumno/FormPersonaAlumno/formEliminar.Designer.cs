namespace FormPersonaAlumno
{
    partial class formEliminar
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
            this.alumnoEliminarLstBox = new System.Windows.Forms.ListBox();
            this.eliminarAlumnoBtn = new System.Windows.Forms.Button();
            this.cancelarEliminarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alumnoEliminarLstBox
            // 
            this.alumnoEliminarLstBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.alumnoEliminarLstBox.FormattingEnabled = true;
            this.alumnoEliminarLstBox.Location = new System.Drawing.Point(316, 32);
            this.alumnoEliminarLstBox.Name = "alumnoEliminarLstBox";
            this.alumnoEliminarLstBox.Size = new System.Drawing.Size(406, 368);
            this.alumnoEliminarLstBox.TabIndex = 2;
            // 
            // eliminarAlumnoBtn
            // 
            this.eliminarAlumnoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eliminarAlumnoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.eliminarAlumnoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarAlumnoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.eliminarAlumnoBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminarAlumnoBtn.Location = new System.Drawing.Point(85, 118);
            this.eliminarAlumnoBtn.Name = "eliminarAlumnoBtn";
            this.eliminarAlumnoBtn.Size = new System.Drawing.Size(190, 47);
            this.eliminarAlumnoBtn.TabIndex = 3;
            this.eliminarAlumnoBtn.Text = "Eliminar";
            this.eliminarAlumnoBtn.UseVisualStyleBackColor = true;
            this.eliminarAlumnoBtn.Click += new System.EventHandler(this.eliminarAlumnoBtn_Click);
            // 
            // cancelarEliminarBtn
            // 
            this.cancelarEliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelarEliminarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.cancelarEliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarEliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cancelarEliminarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelarEliminarBtn.Location = new System.Drawing.Point(85, 289);
            this.cancelarEliminarBtn.Name = "cancelarEliminarBtn";
            this.cancelarEliminarBtn.Size = new System.Drawing.Size(190, 47);
            this.cancelarEliminarBtn.TabIndex = 4;
            this.cancelarEliminarBtn.Text = "Cancelar";
            this.cancelarEliminarBtn.UseVisualStyleBackColor = true;
            this.cancelarEliminarBtn.Click += new System.EventHandler(this.cancelarEliminarBtn_Click);
            // 
            // formEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(160)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelarEliminarBtn);
            this.Controls.Add(this.eliminarAlumnoBtn);
            this.Controls.Add(this.alumnoEliminarLstBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEliminar";
            this.Text = "formEliminar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox alumnoEliminarLstBox;
        private System.Windows.Forms.Button eliminarAlumnoBtn;
        private System.Windows.Forms.Button cancelarEliminarBtn;
    }
}