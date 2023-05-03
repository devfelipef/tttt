using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Triangulo : Figura
    {
        public double A { get; set; }
        public double B { get; set; }
       

        public override double CalcularArea => this.A * this.B/2;

    }
}
