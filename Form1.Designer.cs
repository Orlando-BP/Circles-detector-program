
namespace DetectorDeCirculos
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.buttonCargarImagen = new System.Windows.Forms.Button();
            this.openFileDialogImagen = new System.Windows.Forms.OpenFileDialog();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            this.buttonSalirDePrograma = new System.Windows.Forms.Button();
            this.buttonCreditos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(598, 426);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagen.TabIndex = 0;
            this.pictureBoxImagen.TabStop = false;
            // 
            // buttonCargarImagen
            // 
            this.buttonCargarImagen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCargarImagen.Location = new System.Drawing.Point(620, 12);
            this.buttonCargarImagen.Name = "buttonCargarImagen";
            this.buttonCargarImagen.Size = new System.Drawing.Size(172, 52);
            this.buttonCargarImagen.TabIndex = 1;
            this.buttonCargarImagen.Text = "Cargar Imagen";
            this.buttonCargarImagen.UseVisualStyleBackColor = true;
            this.buttonCargarImagen.Click += new System.EventHandler(this.buttonCargarImagen_Click);
            // 
            // openFileDialogImagen
            // 
            this.openFileDialogImagen.FileName = "openFileDialogImagen";
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAnalizar.Location = new System.Drawing.Point(620, 86);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(172, 52);
            this.buttonAnalizar.TabIndex = 2;
            this.buttonAnalizar.Text = "Analizar Imagen";
            this.buttonAnalizar.UseVisualStyleBackColor = true;
            this.buttonAnalizar.Click += new System.EventHandler(this.buttonAnalizar_Click);
            // 
            // buttonSalirDePrograma
            // 
            this.buttonSalirDePrograma.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalirDePrograma.Location = new System.Drawing.Point(695, 390);
            this.buttonSalirDePrograma.Name = "buttonSalirDePrograma";
            this.buttonSalirDePrograma.Size = new System.Drawing.Size(93, 48);
            this.buttonSalirDePrograma.TabIndex = 3;
            this.buttonSalirDePrograma.Text = "Salir";
            this.buttonSalirDePrograma.UseVisualStyleBackColor = true;
            this.buttonSalirDePrograma.Click += new System.EventHandler(this.buttonSalirDePrograma_Click);
            // 
            // buttonCreditos
            // 
            this.buttonCreditos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreditos.Location = new System.Drawing.Point(620, 405);
            this.buttonCreditos.Name = "buttonCreditos";
            this.buttonCreditos.Size = new System.Drawing.Size(69, 26);
            this.buttonCreditos.TabIndex = 4;
            this.buttonCreditos.Text = "Creditos";
            this.buttonCreditos.UseVisualStyleBackColor = true;
            this.buttonCreditos.Click += new System.EventHandler(this.buttonCreditos_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreditos);
            this.Controls.Add(this.buttonSalirDePrograma);
            this.Controls.Add(this.buttonAnalizar);
            this.Controls.Add(this.buttonCargarImagen);
            this.Controls.Add(this.pictureBoxImagen);
            this.Name = "FormInicio";
            this.Text = "Detector de Circulos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button buttonCargarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagen;
        private System.Windows.Forms.Button buttonAnalizar;
        private System.Windows.Forms.Button buttonSalirDePrograma;
        private System.Windows.Forms.Button buttonCreditos;
    }
}

