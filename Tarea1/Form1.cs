using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvendo, gracias por usar mi calculadora");
        }

        private void comboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string optionselected = comboOpciones.Text;
            switch (optionselected)
            {
                case "Suma":
                    break;
                case "Resta":
                    break;
                case "Multiplicacion":
                    break;
                case "Division":
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensaje = btnCalcular.Text;
            if (mensaje == "")
            {
                MessageBox.Show("Debe ingresar un dato");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
 
        

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {


            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            var resta = num1 - num2;
            MessageBox.Show(resta.ToString());

            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            var multiplicacion = num1 * num2;
            MessageBox.Show(multiplicacion.ToString());

            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            var division = num1 / num2;
            MessageBox.Show(division.ToString());
        }
    }
}
