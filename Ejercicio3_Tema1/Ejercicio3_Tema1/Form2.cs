using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Tema1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Método más apropiado para cargar datos justo antes de visualizar el formulario
        private void Form2_Load(object sender, EventArgs e)
        {
            if (base.Owner != null)
            {
                // Muestra el nombre/tipo del formulario principal que lo ha creado
                Owner.Text = "Owner: " + base.Owner.ToString();
            }
            else
            {
                Owner.Text = "referencia al propietario no establecida";
            }
        }
        private void Owner_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            //cuando pulsas aceptar despues de el primero
            MessageBox.Show(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy "));
            //el siguiente formato
            MessageBox.Show(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy - hh:mm:ss tt"));
            //el ultimo
            MessageBox.Show(DateTime.Now.ToString("hh:mm:ss tt 'año' yyy 'mes' MMM 'dia' dddd "));

            // Llamada al método del formulario principal usando base.Owner para evitar conflictos con la etiqueta
            if (base.Owner != null)
            {
                (base.Owner as Form1).Mensaje(DateTime.Now.ToShortTimeString());
            }
        }
    }
}