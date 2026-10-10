using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8_Tema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertimos los valores de las dos primeras cajas de texto y realizamos la resta
                double valor1 = Convert.ToDouble(textBoxEx1.Text);
                double valor2 = Convert.ToDouble(textBoxEx2.Text);

                double resultado = valor1 - valor2;

                // Mostramos el resultado en la tercera caja de texto
                textBoxEx3.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Introduce valores numéricos válidos en las cajas de texto.");
            }
        }
    }
}
