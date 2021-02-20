using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio_LibCalc
{
    public class Resta : Operacion
    {
        string nombre = "Clase HIJA.. this , que se llama RESTA";
        public Resta(double op1, double op2) : base(op1, op2)
        {
            Console.WriteLine("El valor de THIS objeto de nombre es: " + this.nombre);
            Console.WriteLine("El valor de la case BASE de nombre es: " + base.nombre);

        }
        public override double ejecutar()
        {
            return this.Ope1 - this.Ope2;
        }

    }
}
