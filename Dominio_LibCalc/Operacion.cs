using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public abstract class Operacion
    {
        public string nombre = "Clase BASE";
        public double Ope1 { get; set; }
        public double Ope2 { get; set; }
        public Operacion(double op1, double op2)
        {
            this.Ope1 = op1;
            this.Ope2 = op2;
        }
             public abstract double ejecutar();

    }
}
