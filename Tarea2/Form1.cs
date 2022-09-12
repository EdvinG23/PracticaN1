using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Calcula el interes; facil, rapido y seguro");
        }

        private void comboOpc_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string optionselected = comboOpc.Text;
            double num1 = double.Parse(txtNu1.Text);
            double num2 = double.Parse(txtNu2.Text);
            double num3 = double.Parse(txtNu3.Text);


            switch (optionselected)
            {
                case "Diario":
                    var diario = num1 * num2 * num3/360;
                    MessageBox.Show(diario.ToString());
                    break;
                case "Mensual":
                    var mensual = num1 * num2 * num3/12;
                    MessageBox.Show(mensual.ToString());
                    break;
                case "Anual":
                    var anual = num1 * num2 * num3;
                    MessageBox.Show(anual.ToString());
                    break;
            }
        }
    }
}
    
