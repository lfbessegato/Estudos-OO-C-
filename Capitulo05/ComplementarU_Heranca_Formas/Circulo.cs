using System;
using System.Collections.Generic;
using System.Text;

namespace ComplementarU_Heranca_Formas
{
    class Circulo : Forma
    {
        public double Raio { get; set; }
        public override double Area => (Math.PI * Math.Pow(Raio,Raio));
        public double Diametro => (Raio * 2);
    }
}
