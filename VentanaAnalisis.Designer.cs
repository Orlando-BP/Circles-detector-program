
namespace DetectorDeCirculos
{
    partial class VentanaAnalisis
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
            this.pictureBoxImagenAnalizada = new System.Windows.Forms.PictureBox();
            this.listViewLista = new System.Windows.Forms.ListView();
            this.columnId = new System.Windows.Forms.ColumnHeader();
            this.ColumnColor = new System.Windows.Forms.ColumnHeader();
            this.columnCentroX = new System.Windows.Forms.ColumnHeader();
            this.columnCentroY = new System.Windows.Forms.ColumnHeader();
            this.columnRadio = new System.Windows.Forms.ColumnHeader();
            this.columnArea = new System.Windows.Forms.ColumnHeader();
            this.buttonCerrarAnalizis = new System.Windows.Forms.Button();
            this.buttonOrdenarArea = new System.Windows.Forms.Button();
            this.buttonOrdenarX = new System.Windows.Forms.Button();
            this.buttonOrdenarY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenAnalizada)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagenAnalizada
            // 
            this.pictureBoxImagenAnalizada.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImagenAnalizada.Name = "pictureBoxImagenAnalizada";
            this.pictureBoxImagenAnalizada.Size = new System.Drawing.Size(598, 426);
            this.pictureBoxImagenAnalizada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenAnalizada.TabIndex = 0;
            this.pictureBoxImagenAnalizada.TabStop = false;
            // 
            // listViewLista
            // 
            this.listViewLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.ColumnColor,
            this.columnCentroX,
            this.columnCentroY,
            this.columnRadio,
            this.columnArea});
            this.listViewLista.HideSelection = false;
            this.listViewLista.Location = new System.Drawing.Point(616, 13);
            this.listViewLista.Name = "listViewLista";
            this.listViewLista.Size = new System.Drawing.Size(463, 425);
            this.listViewLista.TabIndex = 1;
            this.listViewLista.UseCompatibleStateImageBehavior = false;
            this.listViewLista.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "IdCirculo";
            // 
            // ColumnColor
            // 
            this.ColumnColor.Text = "Color";
            this.ColumnColor.Width = 100;
            // 
            // columnCentroX
            // 
            this.columnCentroX.Text = "Centro X";
            // 
            // columnCentroY
            // 
            this.columnCentroY.Text = "Centro Y";
            // 
            // columnRadio
            // 
            this.columnRadio.Text = "Radio";
            // 
            // columnArea
            // 
            this.columnArea.Text = "Area";
            this.columnArea.Width = 120;
            // 
            // buttonCerrarAnalizis
            // 
            this.buttonCerrarAnalizis.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCerrarAnalizis.Location = new System.Drawing.Point(12, 444);
            this.buttonCerrarAnalizis.Name = "buttonCerrarAnalizis";
            this.buttonCerrarAnalizis.Size = new System.Drawing.Size(143, 38);
            this.buttonCerrarAnalizis.TabIndex = 2;
            this.buttonCerrarAnalizis.Text = "Cerrar Analisis";
            this.buttonCerrarAnalizis.UseVisualStyleBackColor = true;
            this.buttonCerrarAnalizis.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOrdenarArea
            // 
            this.buttonOrdenarArea.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrdenarArea.Location = new System.Drawing.Point(637, 446);
            this.buttonOrdenarArea.Name = "buttonOrdenarArea";
            this.buttonOrdenarArea.Size = new System.Drawing.Size(125, 38);
            this.buttonOrdenarArea.TabIndex = 3;
            this.buttonOrdenarArea.Text = "Ordenar por area";
            this.buttonOrdenarArea.UseVisualStyleBackColor = true;
            this.buttonOrdenarArea.Click += new System.EventHandler(this.buttonOrdenarArea_Click);
            // 
            // buttonOrdenarX
            // 
            this.buttonOrdenarX.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrdenarX.Location = new System.Drawing.Point(768, 446);
            this.buttonOrdenarX.Name = "buttonOrdenarX";
            this.buttonOrdenarX.Size = new System.Drawing.Size(142, 38);
            this.buttonOrdenarX.TabIndex = 4;
            this.buttonOrdenarX.Text = "Ordenar por eje X";
            this.buttonOrdenarX.UseVisualStyleBackColor = true;
            this.buttonOrdenarX.Click += new System.EventHandler(this.buttonOrdenarX_Click);
            // 
            // buttonOrdenarY
            // 
            this.buttonOrdenarY.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrdenarY.Location = new System.Drawing.Point(916, 446);
            this.buttonOrdenarY.Name = "buttonOrdenarY";
            this.buttonOrdenarY.Size = new System.Drawing.Size(142, 38);
            this.buttonOrdenarY.TabIndex = 5;
            this.buttonOrdenarY.Text = "Ordenar por eje Y";
            this.buttonOrdenarY.UseVisualStyleBackColor = true;
            this.buttonOrdenarY.Click += new System.EventHandler(this.buttonOrdenarY_Click);
            // 
            // VentanaAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 486);
            this.Controls.Add(this.buttonOrdenarY);
            this.Controls.Add(this.buttonOrdenarX);
            this.Controls.Add(this.buttonOrdenarArea);
            this.Controls.Add(this.buttonCerrarAnalizis);
            this.Controls.Add(this.listViewLista);
            this.Controls.Add(this.pictureBoxImagenAnalizada);
            this.Name = "VentanaAnalisis";
            this.Text = "VentanaAnalisis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenAnalizada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagenAnalizada;
        private System.Windows.Forms.ListView listViewLista;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnCentroX;
        private System.Windows.Forms.ColumnHeader columnCentroY;
        private System.Windows.Forms.ColumnHeader columnRadio;
        private System.Windows.Forms.ColumnHeader columnArea;
        private System.Windows.Forms.Button buttonCerrarAnalizis;
        private System.Windows.Forms.ColumnHeader ColumnColor;
        private System.Windows.Forms.Button buttonOrdenarArea;
        private System.Windows.Forms.Button buttonOrdenarX;
        private System.Windows.Forms.Button buttonOrdenarY;
    }
}