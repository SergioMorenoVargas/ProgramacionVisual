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
    public partial class DlgEliminarZona : Form
    {
        private List<ZonaHoraria> m_Zonas;
        public DlgEliminarZona()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        private void DlgEliminarZona_Load(object sender, EventArgs e)
        {
            // 1. Asignar la colección m_Zonas desde la propiedad Zonas de RelojDigital usando Owner
            RelojDigital reloj = this.Owner as RelojDigital;
            if (reloj != null)
            {
                m_Zonas = reloj.Zonas;
            }

            // 2. Rellenar el ListBox lb_Zonas con los nombres de las zonas (usando foreach)
            if (m_Zonas != null)
            {
                lb_Zonas.Items.Clear();
                foreach (ZonaHoraria zona in m_Zonas)
                {
                    lb_Zonas.Items.Add(zona.Nombre);
                }
            }

            // 3. Seleccionar el primer elemento si la lista tiene elementos
            if (lb_Zonas.Items.Count > 0)
            {
                lb_Zonas.SelectedIndex = 0;
            }
        }

        private void ct_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_Zonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Zonas.SelectedItem != null)
            {
                string nombreZona = lb_Zonas.SelectedItem.ToString();

                ZonaHoraria zonaSeleccionada = m_Zonas.Find(
                    delegate (ZonaHoraria zona)  // predicado anónimo
                    {
                        return zona.Nombre == nombreZona;
                    }
                );
                if (zonaSeleccionada != null)
                {
                    ct_Diferencia.Text = zonaSeleccionada.Diferencia.ToString(@"hh\:mm");
                    ct_Signo.Text = zonaSeleccionada.Positivo ? "+" : "-";
                }
            }
        }

        private int m_ZonaSeleccionada = -1;
        public int ZonaSeleccionada
        {
            get { return m_ZonaSeleccionada; }
        }

        //manejador del boton aceptar
        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (lb_Zonas.SelectedIndex != -1)
            {
                m_ZonaSeleccionada = lb_Zonas.SelectedIndex;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}