using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Circulo : Figura
    {
        public double Raio { get; set; }
        public override double CalcularArea => Math.Pow(this.Raio, 2) * Math.PI;

    }
}
