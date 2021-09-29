using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectorDeCirculos
{
    public partial class FormInicio : Form
    {
        Bitmap bmpImagen;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonSalirDePrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCargarImagen_Click(object sender, EventArgs e)
        {
            openFileDialogImagen.ShowDialog();
            bmpImagen = new Bitmap(openFileDialogImagen.FileName);
            pictureBoxImagen.Image = bmpImagen;
        }

        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
            if(bmpImagen != null) 
            {
                VentanaAnalisis VAnalisis = new VentanaAnalisis(bmpImagen);
                MessageBox.Show("Circulos Localizados y Analizandos!!");
                VAnalisis.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("No cargaste una Imagen");
            }
        }

        private void buttonCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa de deteccion de circulos 1.1\nProgramador: Orlando Barba (Orlando-BP)\nContacto: orlando.barba.13@gmail.com\nFecha: 05/09/2021");
        }
    }
}
