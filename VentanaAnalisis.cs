using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DetectorDeCirculos
{
    public partial class VentanaAnalisis : Form
    {
        Bitmap bmpImagen;
        List<Circulo> Lista;
        public VentanaAnalisis(Bitmap bmpImagen)
        {
            InitializeComponent();
            this.bmpImagen = bmpImagen;
            this.Lista = new List<Circulo>();
            pictureBoxImagenAnalizada.Image = bmpImagen;
            RecorrerImagen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void RecorrerImagen()
        {
            Color color;
            string NombreColor;
            for(int Y = 1; Y < bmpImagen.Height; Y++)
            {
                for(int X = 1; X < bmpImagen.Width; X++)
                {
                    color = bmpImagen.GetPixel(X, Y);
                    NombreColor = color.Name;
                    if(NombreColor == "ff000000" || NombreColor == "ff999999" /*|| NombreColor == "ffdddddd"*/)
                    {
                        if (ValidacionDePixel(X,Y))//Señala si no se registro un circulo en ese pixel
                        {
                            int[] datosCirculo = new int[3];
                            datosCirculo = EncontrarDatosCirculo(X, Y);
                            RegistrarCirculo(datosCirculo);
                        }
                    }
                }
            }
        }
        string AsignarColor(int id)
        {
            string color = "Ninguno";
            switch (id)
            {
                case 1:
                    color = "Aqua";
                    break;
                case 2:
                    color = "Blue";
                    break;
                case 3:
                    color = "BlueViolet";
                    break;
                case 4:
                    color = "Brown";
                    break;
                case 5:
                    color = "Chartreuse";
                    break;
                case 6:
                    color = "Crimson";
                    break;
                case 7:
                    color = "Cyan";
                    break;
                case 8:
                    color = "DarkGreen";
                    break;
                case 9:
                    color = "DarkOrange";
                    break;
                case 10:
                    color = "Gold";
                    break;
                case 11:
                    color = "HotPink";
                    break;
                case 12:
                    color = "LemonChiffon";
                    break;
                case 13:
                    color = "LightSeaGreen";
                    break;
                case 14:
                    color = "LightSlateGray";
                    break;
                case 15:
                    color = "Linen";
                    break;
                case 16:
                    color = "Peru";
                    break;
                case 17:
                    color = "Red";
                    break;
                case 18:
                    color = "RoyalBlue";
                    break;
                case 19:
                    color = "Tomato";
                    break;
                case 20:
                    color = "YellowGreen";
                    break;

                default:
                    color = "AliceBlue";
                    break;

            }
            return color;
        }
        void RegistrarCirculo(int[] datos)
        {
            int id = (Lista.Count)+1;
            string color = AsignarColor(id);
            int centroX = datos[0]; 
            int centroY = datos[1]; 
            int radio = datos[2];
            
            Circulo NuevoCirculo = new Circulo(id, color, centroX, centroY, radio);
            Lista.Add(NuevoCirculo);
            DibujarCirculo(datos, id);
            MostrarLista();
        }

        int[] EncontrarDatosCirculo(int X0, int Y0)
        {
            int y_superior = Y0;
            int y_inferior = Y0;
            Color color = bmpImagen.GetPixel(X0, y_inferior +1);
            string NombreColor = color.Name;
            while (NombreColor != "ffffffff")
            {
                y_inferior++;
                color = bmpImagen.GetPixel(X0, y_inferior + 1);
                NombreColor = color.Name;
            }
            int y_centro = (y_inferior + y_superior) / 2;
            int x_derecho = X0;

            color = bmpImagen.GetPixel(x_derecho +1, y_centro);
            NombreColor = color.Name;
            while (NombreColor != "ffffffff")
            {
                x_derecho++;
                color = bmpImagen.GetPixel(x_derecho + 1, y_centro);
                NombreColor = color.Name;
            }

            int x_izquierda = X0;

            color = bmpImagen.GetPixel(x_izquierda - 1, y_centro);
            NombreColor = color.Name;
            while (NombreColor != "ffffffff")
            {
                x_izquierda--;
                color = bmpImagen.GetPixel(x_izquierda - 1, y_centro);
                NombreColor = color.Name;
            }

            int x_centro = (x_derecho + x_izquierda) / 2;

            int[] datos = new int[3];
            datos[0] = x_centro; ;//centro del circulo en X
            datos[1] = y_centro;//centro del circulo en Y
            datos[2] = y_inferior - y_centro;//redio
            return datos;
        }

        bool ValidacionDePixel(int X, int Y)//true para registrar nuevo circulo, false para circulo visto
        {
            double Comprobante = 0;
            foreach(Circulo c in Lista)
            {
               double OperacionX = Math.Pow(X - c.getCentroX(), 2);
               double OperacionY = Math.Pow(Y - c.getCentroY(), 2);
               double OperacionR = Math.Pow(c.getRadio()+2, 2);// Aqui aumento en 2 el radio por los pixeles de s`paracion entre circulos, asi evito el ruido
               Comprobante = OperacionX + OperacionY - OperacionR;
                if (Comprobante <= 0)
                    return false;
            }
           return true;
        }

        void DibujarCirculo(int[] datos,int id)
        {
            int D = datos[2] * 2;
            int Center = 12;
            int Contorno = 20;
            Graphics dibujo = Graphics.FromImage(bmpImagen);
            Brush brochacirculo = new SolidBrush(DarColor(id));
            Brush brochacirculointerior = new SolidBrush(Color.Black);
            Brush brochacentro = new SolidBrush(Color.Red);
            dibujo.FillEllipse(brochacirculo, datos[0] - D / 2, datos[1] - D / 2, D, D);
            dibujo.FillEllipse(brochacirculointerior, datos[0] - (D- Contorno) / 2, datos[1] - (D - Contorno) / 2, D- Contorno, D- Contorno);
            dibujo.FillEllipse(brochacentro, datos[0] - Center / 2, datos[1] - Center / 2, Center, Center);
            pictureBoxImagenAnalizada.Refresh();
        }
        Color DarColor(int id)
        {
            switch (id)
            {
                case 1:
                    return Color.Aqua;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.BlueViolet;
                case 4:
                    return Color.Brown;
                case 5:
                    return Color.Chartreuse;
                case 6:
                    return Color.Crimson;
                case 7:
                    return Color.Cyan;
                case 8:
                    return Color.DarkGreen;
                case 9:
                    return Color.DarkOrange;
                case 10:
                    return Color.Gold;
                case 11:
                    return Color.HotPink;
                case 12:
                    return Color.LemonChiffon;
                case 13:
                    return Color.LightSeaGreen;
                case 14:
                    return Color.LightSlateGray;
                case 15:
                    return Color.Linen;
                case 16:
                    return Color.Peru;
                case 17:
                    return Color.Red;
                case 18:
                    return Color.RoyalBlue;
                case 19:
                    return Color.Tomato;
                case 20:
                    return Color.YellowGreen;

                default:
                    return Color.AliceBlue;
            }
        }

        void OrdenarListaBubbleSort()//Por Tamaño de Area de circulo
        {
            int n = Lista.Count - 1;
            for(int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= n-1; j++)
                {
                    double a = Lista[j].getArea();
                    double b = Lista[j+1].getArea();
                    if (a > b)
                    {
                        IntercambiarPosicion(j, j + 1);
                    }
                        
                }
            }
            MostrarLista();
        }
        
        void OrdenarListaSelectionSort()// ordenar por eje X
        {
            int n = Lista.Count;
            for (int j = 0; j < n - 1; j++)
            {
                int minimo = j;
                for(int i = j + 1; i < n; i++)
                {
                    if(Lista[i].getCentroX() < Lista[minimo].getCentroX())
                    {
                        minimo = i;
                    }
                }
                if(minimo != j)
                {
                    IntercambiarPosicion(j, minimo);
                }
            }
            MostrarLista();
        }

        void OrdenarListaInsertionSort()// ordenar por eje Y
        {
            int n = Lista.Count - 1;
            for(int i = 1; i <= n; i++)
            {
                int j = i;
                while(j > 0 && Lista[j-1].getCentroY() > Lista[j].getCentroY())
                {
                    IntercambiarPosicion(j, j - 1);
                    j--;
                }
            }
            MostrarLista();
        }
        void MostrarLista()
        {
            listViewLista.Items.Clear();
            foreach (Circulo c in Lista)
            {
                string[] registro = new string[6];

                registro[0] = c.GetId().ToString();
                registro[1] = c.GetColor();
                registro[2] = c.getCentroX().ToString();
                registro[3] = c.getCentroY().ToString();
                registro[4] = c.getRadio().ToString();
                registro[5] = c.getArea().ToString();

                ListViewItem item = new ListViewItem(registro);
                listViewLista.Items.Add(item);
            }
        }

        void IntercambiarPosicion(int posicion1, int posicion2)
        {
            Circulo auxiliar = Lista[posicion2];
            Lista[posicion2] = Lista[posicion1];
            Lista[posicion1] = auxiliar;
        }
        private void buttonOrdenarArea_Click(object sender, EventArgs e)
        {
            OrdenarListaBubbleSort();
        }

        private void buttonOrdenarX_Click(object sender, EventArgs e)
        {
            OrdenarListaSelectionSort();
        }

        private void buttonOrdenarY_Click(object sender, EventArgs e)
        {
            OrdenarListaInsertionSort();
        }
    }
}
