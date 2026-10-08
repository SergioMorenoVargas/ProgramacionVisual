using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Reloj
{
    public partial class DlgDatosZona : Form
    {
        private string m_Nombre;
        private TimeSpan m_Diferencia;
        private bool m_Positivo;
        public DlgDatosZona()
        {
            InitializeComponent();
        }
        public string Nombre
        {
            get { return m_Nombre; }
            set { m_Nombre = value; }
        }

        public TimeSpan Diferencia
        {
            get { return m_Diferencia; }
            set { m_Diferencia = value; }
        }

        public bool Positivo
        {
            get { return m_Positivo; }
            set { m_Positivo = value; }
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rb_Negativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DlgDatosZona_Load(object sender, EventArgs e)
        {

        }

        private void bt_Aceptar_Click_1(object sender, EventArgs e)
        {
            if (ct_Nombre.Text.Trim() != "")
            {
                this.Nombre = ct_Nombre.Text;
            }
            else
            {
                MessageBox.Show("Debe introducir un nombre para la zona horaria",
                                "Error en los datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                ct_Nombre.Focus();
                return;
            }

            if (ct_Diferencia.HoraValida)
            {
                DateTime hora = ct_Diferencia.Hora;
                this.Diferencia = new TimeSpan(hora.Hour, hora.Minute, hora.Second);
            }
            else
            {
                MessageBox.Show("Introduzca una diferencia horaria válida",
                                "Error en los datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                ct_Diferencia.Focus();
                ct_Diferencia.SelectAll();
                return;
            }

            this.Positivo = rb_Positivo.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
