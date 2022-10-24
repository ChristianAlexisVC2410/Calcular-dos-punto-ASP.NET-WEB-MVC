using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularDosPuntos.Models
{
    public class Puntos
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Result { get; set; }

        public void CalcularPuntos()
        {
            this.Result = Math.Sqrt(Math.Pow((this.X2 - this.X1),2)+(Math.Pow((this.Y2-this.Y1),2)));
        }


    }
}