using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormEjercicio1;

namespace WinFormEjercicio1
{
    public partial class FrmCalculadora : Form
    {
        //var de class abstract para acceder a TODAS las operaciones
        Operacion oper = null;

        string operador = "";
        //operandos
        private double _op1 = 0;
        private double _op2 = 0;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "+";
            //tomamos op1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //capturamos el op2
            this._op2 = double.Parse(txtDisplay.Text);
            //instanciamos la clase de la operación seleccionada
            switch (this.operador)
            {
                case "+":
                    oper = new Suma(this._op1, this._op2);
                    break;
                case "-":
                    oper = new Resta(this._op1, this._op2);
                    break;
                case "*":
                    oper = new Multiplicacion(this._op1, this._op2);
                    break;
                case "/":
                    oper = new Division(this._op1, this._op2);
                    break;
                
                default:
                    operador = "";
                    break;
            }
            //ejecutamos la operación
            txtDisplay.Text = oper.ejecutar().ToString();
            //limpiar operador =
            this.operador = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "-";
            //tomamos op1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "/";
            //tomamos op1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "*";
            //tomamos op1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //falta editar el punto para que no se agregue mas de una vez
            txtDisplay.Text += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
