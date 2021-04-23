using System;
using System.Collections.Generic;
using System.Text;

namespace ComplementarU_Heranca_Formas
{
    class Retangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double Area => (Base * Altura);
        public bool EhUmQuadrado => Base == Altura;
    }
}
