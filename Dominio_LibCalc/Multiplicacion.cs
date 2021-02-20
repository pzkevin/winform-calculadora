using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class Multiplicacion : Operacion
    {
        public Multiplicacion(double op1, double op2) : base(op1, op2)
        {
        }
        public override double ejecutar()
        {
            return this.Ope1 * this.Ope2;
        }
    }
}
