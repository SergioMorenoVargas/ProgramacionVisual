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
        public DlgEliminarZona()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        private void DlgEliminarZona_Load(object sender, EventArgs e)
        {
            // Dejamos este método vacío por ahora para que el diseñador no dé error
        }

        private void ct_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}