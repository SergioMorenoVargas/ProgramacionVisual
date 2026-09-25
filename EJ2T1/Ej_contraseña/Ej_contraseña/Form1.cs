using System;
using System.Windows.Forms;

namespace Ej_contraseña
{
    public partial class Form1 : Form
    {
        private const string CLAVE_CORRECTA = "1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int intentos = 0;
            bool accesoConcedido = false;

            while (intentos < 3 && !accesoConcedido)
            {
                
                DlgContraseña dlg = new DlgContraseña();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.sContraseña == CLAVE_CORRECTA)
                    {
                        accesoConcedido = true;
                        MessageBox.Show("La palabra de paso es correcta",
                                        "Correcto",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        intentos++;
                        MessageBox.Show("La palabra de paso no es correcta",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Application.Exit();
                    return;
                }
            }

            if (!accesoConcedido)
            {
                Application.Exit();
            }
        }
    }
}