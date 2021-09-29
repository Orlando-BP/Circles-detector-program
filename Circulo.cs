using System;
using System.Collections.Generic;
using System.Text;

namespace DetectorDeCirculos
{
    class Circulo
    {
        int Id;
        string Color;
        int CentroX;
        int CentroY;
        int Radio;
        Double Area;

        public Circulo(int id,string color, int centroX, int centroY, int radio)
        {
            Id = id;
            Color = color;
            CentroX = centroX;
            CentroY = centroY;
            Radio = radio;
            Area = Math.PI * Math.Pow(Radio, 2);
        }

        public int GetId()
        {
            return Id;
        }
        public string GetColor()
        {
            return Color;
        }
        public int getCentroX()
        {
            return CentroX;
        }
        public int getCentroY()
        {
            return CentroY;
        }
        public int getRadio()
        {
            return Radio;
        }
        public Double getArea()
        {
            return Area;
        }
    }
}
