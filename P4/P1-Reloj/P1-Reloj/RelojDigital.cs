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
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        private RelojAnalogico m_RelojAnalogico = new RelojAnalogico();

        public RelojDigital()
        {
            InitializeComponent();

            ct_HoraActual.Font = new Font("Times New Roman", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            ct_HoraActual.BackColor = Color.White;
            ct_HoraActual.ForeColor = Color.Blue;

            MostrarHoraActual();

            OpcionesDespertadorActivar.Click += opcionesDespertadorActivar_Click;
            OpcionesDespertadorDesactivar.Click += opcionesDespertadorDesactivar_Click;

            menuContextoZona.Opening += menuContextoZona_Opening;

 
        }

        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalogico.Show(this);
            m_RelojAnalogico.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalogico.Hora = hora;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHoraActual();

            if (!DespertadorActivado)
                return;

            if (!ct_Alarma.HoraValida)
            {
                System.Diagnostics.Debug.WriteLine("Hora alarma no válida");
                return;
            }

            DateTime horaActual = DateTime.Now + m_DesfaseHorario;
            DateTime horaAlarma = ct_Alarma.Hora;

            int segundosActual = horaActual.Second
                               + horaActual.Minute * 60
                               + horaActual.Hour * 3600;

            // Segundos alarma:
            int segundosAlarma = horaAlarma.Second
                               + horaAlarma.Minute * 60
                               + horaAlarma.Hour * 3600;
            if (segundosActual >= segundosAlarma)
            {
                if (segundosActual - segundosAlarma < 300)
                    System.Media.SystemSounds.Beep.Play(); // Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                    
            }
            else if (segundosAlarma - segundosActual > 86400 - 300)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
            }
        }

        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
            m_DesfaseHorario = hora - actual;
            MostrarHoraActual();
        }

        private void menu_ColorFondo_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.Color = ct_HoraActual.BackColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.BackColor = dlgColor.Color;
            }
        }

        private void menu_ColorTexto_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.Color = ct_HoraActual.ForeColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.ForeColor = dlgColor.Color;
            }
        }

        private void menu_Fuente_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            dlgFont.Font = ct_HoraActual.Font;
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.Font = dlgFont.Font;
            }
        }

        private void menu_MostrarAnalogico_Click(object sender, EventArgs e)
        {
            m_RelojAnalogico.Visible = !m_RelojAnalogico.Visible;
            menu_MostrarAnalogico.Checked = m_RelojAnalogico.Visible;
        }

        private void opcionesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            menu_MostrarAnalogico.Checked = m_RelojAnalogico.Visible;
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
 
        private bool m_DespertadorActivado = false;

        public bool DespertadorActivado
        {
            get { return m_DespertadorActivado; }
            set
            {
                m_DespertadorActivado = value;
                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;

                cv_Despertador.Checked = m_DespertadorActivado;
            }
        }
        private void opcionesDespertadorActivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = true;
        }
        private void opcionesDespertadorDesactivar_Click(object sender, EventArgs e)
        {
            this.DespertadorActivado = false;
        }

        const int MaxZonas = 4;

        public int NúmeroZonas
        {
            get { return menuZona.DropDownItems.Count - 3; }
        }

        private void menuZona_DropDownOpened(object sender, EventArgs e)
        {
            zonaAñadir.Visible = (this.NúmeroZonas < MaxZonas);
            zonaEliminar.Visible = (this.NúmeroZonas > 0);
            zonaSeparador.Visible = (this.NúmeroZonas > 0);
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas >= MaxZonas)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            zonaNueva.Text = "Zona " + (this.NúmeroZonas + 1);
            zonaNueva.Click += zona_Click;
            menuContextoZona.Items.Add(zonaNueva);
        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (this.NúmeroZonas <= 0)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            if (menuContextoZona.Items.Count > 3)
            {
                menuContextoZona.Items.RemoveAt(menuContextoZona.Items.Count - 1);
            }
        }

        private void zona_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                MessageBox.Show("Has seleccionado: " + item.Text, "Zona seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void opcionesDespertador_Click(object sender, EventArgs e)
        {

        }

        private void RelojDigital_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(menuStrip1, Properties.Resources.mensajeBarraMenus);

        }

        private void menuContextoZona_Opening(object sender, CancelEventArgs e)
        {
            zonaAñadir.Visible = (this.NúmeroZonas < MaxZonas);
            zonaEliminar.Visible = (this.NúmeroZonas > 0);
            zonaSeparador.Visible = (this.NúmeroZonas > 0);

        }

        private void menuZona_Click(object sender, EventArgs e)
        {

        }

        private void cv_Despertador_CheckedChanged(object sender, EventArgs e)
        {
            this.DespertadorActivado = !this.DespertadorActivado; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DlgEliminarZona dlg = new DlgEliminarZona();
            dlg.ShowDialog();
        }
    }
}