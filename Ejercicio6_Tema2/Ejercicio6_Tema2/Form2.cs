using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio6_Tema2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 1. Cambiamos el cursor al de espera en el formulario y en el botón
            this.Cursor = Cursors.WaitCursor;
            button1.Cursor = Cursors.WaitCursor;

            // 2. Mantenemos el cursor de espera durante 3 segundos (3000 ms)
            await Task.Delay(3000);

            // 3. Restauramos los cursores iniciales
            this.Cursor = Cursors.Cross;
            button1.Cursor = Cursors.Hand;
        }
    }
}
