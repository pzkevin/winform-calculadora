using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio_LibCalc;

namespace WinFormCalculadora
{
    public partial class FrmCalculadora : Form
    {
        //var de class abrstract para aceder a OTDAS las operaciones
        Operacion oper=null;

        string operador = "";
        //opoerandos
        private double _op1 = 0;
        private double _op2 = 0;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "+";
            //tomamos ope1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
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
            //instanciamos la clase de la ioperacion seleccionada
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
            //imprimiros la prop nombre
            MessageBox.Show("prop nomnnbre= "+oper.nombre);
            //ejecutamos la operacion
            txtDisplay.Text = oper.ejecutar().ToString();

            //limpiar la operador =
            this.operador = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //activar una bandera
            this.operador = "-";
            //tomamos ope1
            this._op1 = double.Parse(txtDisplay.Text);
            //limpiar el display
            txtDisplay.Clear();
        }
    }
}
