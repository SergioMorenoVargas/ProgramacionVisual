using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // directiva necesaria para usar la clase TextBox
using System.ComponentModel; // necesario para Category y Description

namespace Ejercicio8_Tema3
{
    //esto crea un nuevo tipo de control de texto llamado TextBoxEx que hereda
    //de la clase TextBox. Al heredar de TextBox, TextBoxEx tiene todas las
    //propiedades, métodos y eventos de un TextBox normal, pero también se pueden
    //agregar nuevas funcionalidades o modificar las existentes en el futuro.
    public class TextBoxEx : TextBox
    {
        // 1. Declaración de las tres nuevas propiedades solicitadas

        // Lo qu eaparce entre [] sonatributos que proporcionan información adicional sobre las propiedades,
        // como la categoría y la descripción que se mostrará en la ventana de propiedades
        // No afecta a como funciona el código
        [Category("Apariencia"), Description("Almacena el color que mostrará el control cuando reciba el foco, sólo si la propiedad AplicarColorFoco vale true")]
        public Color ColorControlEnfocado { get; set; }

        [Category("Apariencia"), Description("Almacena el color que mostrará el control cuando pierda el foco, sólo si la propiedad AplicarColorFoco vale true")]
        public Color ColorControlDesenfocado { get; set; }

        [Category("Apariencia"), Description("Indica si se debe activar o desactivar el mecanismo de cambio de color")]
        public bool AplicarColorFoco { get; set; }

        // Constructor para inicializar propiedades y añadir manejadores de eventos mediante EventHandler
        public TextBoxEx()
        {
            ColorControlEnfocado = Color.Empty;
            ColorControlDesenfocado = Color.Empty;
            AplicarColorFoco = true;

            this.Enter += new EventHandler(TextBoxEx_Enter);
            this.Leave += new EventHandler(TextBoxEx_Leave);
        }

        private void TextBoxEx_Enter(object sender, EventArgs e)
        {
            if (AplicarColorFoco)
            {
                this.BackColor = ColorControlEnfocado;
            }
        }

        private void TextBoxEx_Leave(object sender, EventArgs e)
        {
            if (AplicarColorFoco)
            {
                this.BackColor = ColorControlDesenfocado;
            }
        }
    }
}