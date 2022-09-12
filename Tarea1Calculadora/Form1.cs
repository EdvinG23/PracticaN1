using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1Calculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar mi calculadora");
        }

        private void comboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string optionselected = comboOpciones.Text;
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            


            switch (optionselected)
            {
                case "Suma":
                    var suma = num1 + num2;
                    MessageBox.Show(suma.ToString());
                    break;
                case "Resta":
                    var resta = num1 - num2;
                    MessageBox.Show(resta.ToString());
                    break;
                case "Multiplicacion":
                    var multiplicacion = num1 * num2;
                    MessageBox.Show(multiplicacion.ToString());
                    break;
                case "Division":
                    if (num2 != 0)
                    {
                        var division = num1 / num2;
                        MessageBox.Show(division.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero, ingresa otro numero");
                        txtNum1.Clear();
                        txtNum2.Clear();
                    }
                    break;
            }


        }

    }
}
