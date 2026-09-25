using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_contraseña
{
    public partial class DlgContraseña : Form
    {
        public DlgContraseña()
        {
            InitializeComponent();
        }
        public string sContraseña
        {
            get {  return this.ctContraseña.Text; }
        }
        private void DlgContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
