using System;
using System.Collections.Generic;
using System.Text;

namespace ComplementarU_Heranca_Formas
{
    abstract class Forma
    {
        public string Nome { get; set; }
        public abstract double Area { get; }

    }
}
