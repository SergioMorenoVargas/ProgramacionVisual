using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Tema1
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
        // Variable a nivel de clase para mantener la referencia del formulario no modal
        private Form2 dlg;
        private void mostrarHoraActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlg == null || dlg.IsDisposed) //Si no se ha creado o si se ha cerrado
                dlg = new Form2();
            if (!dlg.Visible)
                dlg.Show(this); //Al visualizar el Form2 le pasa una referencia del formulario principal
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la aplicación
        }

        // Declaramos la lista accesible para el formulario hijo
        private List<string> mensaje = new List<string>();

        internal void Mensaje(string textoHora)
        {
            mensaje.Add(textoHora);

            // Muestra el string recibido para comprobar que se ha almacenado en la lista
            MessageBox.Show("String recibido y almacenado en la lista: " + textoHora + "\nTotal elementos en lista: " + mensaje.Count);
        }
    }
}
// 1. MODAL vs NO MODAL:
// - ShowDialog() [Modal]: Bloquea Form1. Tienes que cerrar Form2 para volver a usar Form1.
// - Show() [No Modal]: No bloquea nada. Puedes hacer clic e interactuar con ambas ventanas a la vez.

// 2. USO DE Show(this) Y Owner:
// - Al poner 'dlg.Show(this)', le dices a Form2: "tu dueño/padre es este Form1".
// - Así, dentro de Form2 puedes acceder a Form1 mediante la propiedad 'this.Owner'.

// 3. CONTROL CON 'dlg.IsDisposed':
// - 'dlg == null' -> La ventana nunca se ha abierto todavía.
// - 'dlg.IsDisposed' -> La ventana se abrió, pero el usuario la cerró con la 'X'.
// - Comprobar ambas cosas evita que el programa rompa cuando intentas reabrir la ventana.

// 4. EVENTO Load:
// - Se ejecuta automáticamente justo ANTES de mostrar Form2 en pantalla.
// - Es el sitio ideal para poner código porque la propiedad 'Owner' ya tiene los datos de Form1
//   y podemos usarlos para rellenar etiquetas o textos antes de que la ventana se dibuje.