using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7_Tema3
{
    public partial class Form1 : Form
    {
        // Atributo de tipo double dentro de la clase
        private double datoCajaTexto;

        public Form1()
        {
            InitializeComponent();
        }

        private void CajaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Detecta si se ha pulsado Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Cambia el foco a la caja de texto que no lo tiene
                if (sender == textBox1)
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox1.Focus();
                }
                e.Handled = true; // Evita el sonido de alerta al pulsar Enter
            }
        }
        private void CajaTexto_Validating(object sender, CancelEventArgs e)
        {
            TextBox objTextBox = sender as TextBox;
            // Si la caja está vacía, dejamos salir al usuario sin lanzar error,
            //para poder escribir en la otra caja
            if (string.IsNullOrWhiteSpace(objTextBox.Text))
            {
                return;
            }
            try
            {
                datoCajaTexto = Convert.ToDouble(objTextBox.Text);
            }
            catch
            {
                e.Cancel = true; // Impide salir de la caja si el valor no es válido
                errorProvider1.SetError(objTextBox, "Tiene que ser numérico");
            }
        }
        private void CajaTexto_Validated(object sender, EventArgs e)
        {
            TextBox objTextBox = sender as TextBox;

            // Limpiar el mensaje de error
            errorProvider1.SetError(objTextBox, "");

            // Detectar en qué caja de texto se escribió el dato, convertir y escribir en la otra
            if (sender == textBox1)
            {
                // Si se escribió en centígrados, calculamos Fahrenheit
                double fahrenheit = datoCajaTexto * 1.8 + 32;
                textBox2.Text = fahrenheit.ToString("0.00");
            }
            else if (sender == textBox2)
            {
                // Si se escribió en Fahrenheit, calculamos centígrados
                double centigrados = (datoCajaTexto - 32) / 1.8;
                textBox1.Text = centigrados.ToString("0.00");
            }
        }
    }
}
//tener en cuenta que con esto aunq no se escriba nada en la caja de texto,
//al salir de ella se ejecuta el evento Validated y se calcula el valor de la otra caja,
//por eso al seleccionar la otra tienen valor de 0G y 32F por defecto