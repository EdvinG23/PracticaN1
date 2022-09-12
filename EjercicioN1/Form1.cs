using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioN1
{
    public partial class FormHome : Form
    {
        double num1, num2;
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, este es mi primer formulario");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            if (mensaje == "")
            {
                MessageBox.Show("Debe ingresar un dato");
            }else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void comboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string optionselected = comboOpciones.Text;
            // FormHome.B
            switch (optionselected)
            {
                case "Rojo":
                    break;
                case "Azul":
                    break;
                case "Verde":
                    break;
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            var suma = num1 + num2;
            MessageBox.Show(suma.ToString());
        }
    }
}
