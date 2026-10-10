using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Para la serialización
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace P1_Reloj
{
    public partial class RelojDigital : Form
    {
        // =========================================================================
        // 1. RELOJ DIGITAL: Campos, inicialización y actualización de hora
        // EXPLICACIÓN: Lleva el control del tiempo principal. Muestra la hora 
        // actual en pantalla, calcula el tiempo si cambiamos la hora (desfase) 
        // y hace que el reloj avance segundo a segundo con el temporizador (timer1).
        // =========================================================================
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);

        public RelojDigital()
        {
            InitializeComponent();

            // Configuración visual inicial del cuadro de texto de la hora
            ct_HoraActual.Font = new Font("Times New Roman", 16, FontStyle.Regular, GraphicsUnit.Pixel);
            ct_HoraActual.BackColor = Color.White;
            ct_HoraActual.ForeColor = Color.Blue;

            MostrarHoraActual();

            // Asignación manual de manejadores para opciones del despertador y contexto de zonas
            OpcionesDespertadorActivar.Click += opcionesDespertadorActivar_Click;
            OpcionesDespertadorDesactivar.Click += opcionesDespertadorDesactivar_Click;
            menuContextoZona.Opening += menuContextoZona_Opening;

            // Enlace del evento FormClosing para la serialización automática al cerrar
            this.FormClosing += RelojDigital_FormClosing;
        }

        private void RelojDigital_Load(object sender, EventArgs e)
        {
            // Configuración de ayuda flotante (ToolTip) sobre la barra de menú
            toolTip1.SetToolTip(menuStrip1, Properties.Resources.mensajeBarraMenus);

            // SERIALIZACIÓN: Carga de datos de zonas horarias desde fichero ("reloj.dat")
            if (File.Exists("reloj.dat"))
            {
                try
                {
                    using (Stream stream = File.Open("reloj.dat", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        m_Zonas = (List<ZonaHoraria>)bin.Deserialize(stream);

                        // SERIALIZACIÓN: Reconstruir los elementos del menú "Zona" llamando a AñadirOrdenZona
                        foreach (ZonaHoraria nuevaZona in m_Zonas)
                        {
                            AñadirOrdenZona(nuevaZona);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se pudo cargar el archivo de zonas. Causa: " + ex.Message);
                }
            }
        }

        private void MostrarHoraActual()
        {
            // Calcula la hora sumando el desfase y actualiza los dos relojes
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalogico.Hora = hora;
        }

        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            // Modifica la hora calculando un nuevo desfase con la hora real
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
            m_DesfaseHorario = hora - actual;
            MostrarHoraActual();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Actualización periódica de la hora y comprobación de la alarma activa
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

            int segundosAlarma = horaAlarma.Second
                               + horaAlarma.Minute * 60
                               + horaAlarma.Hour * 3600;

            if (segundosActual >= segundosAlarma)
            {
                if (segundosActual - segundosAlarma < 300)
                    System.Media.SystemSounds.Beep.Play();
            }
            else if (segundosAlarma - segundosActual > 86400 - 300)
            {
                Console.Beep();
            }
        }


        // =========================================================================
        // 2. RELOJ ANALÓGICO: Gestión de la ventana secundaria
        // EXPLICACIÓN: Controla la segunda ventana donde se dibuja el reloj con agujas.
        // Se encarga de abrirla pegada a la derecha de la ventana principal y de 
        // ocultarla o mostrarla según lo que elija el usuario en el menú.
        // =========================================================================
        private RelojAnalogico m_RelojAnalogico = new RelojAnalogico();

        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            // Muestra el reloj analógico posicionado justo a la derecha del principal
            m_RelojAnalogico.Show(this);
            m_RelojAnalogico.Location = new Point(
                this.Location.X + this.Width + 10,
                this.Location.Y
            );
        }

        private void menu_MostrarAnalogico_Click(object sender, EventArgs e)
        {
            // Alterna la visibilidad de la ventana analógica y la casilla de ver/ocultar
            m_RelojAnalogico.Visible = !m_RelojAnalogico.Visible;
            menu_MostrarAnalogico.Checked = m_RelojAnalogico.Visible;
        }


        // =========================================================================
        // 3. MENÚ GENERAL Y DIÁLOGOS (Archivo, Opciones, Acerca De)
        // EXPLICACIÓN: Gestiona las acciones básicas de la barra superior, como cerrar 
        // la aplicación ("Salir"), abrir la ventana de información ("Acerca de") y 
        // comprobar qué opciones están marcadas al desplegar el menú.
        // =========================================================================
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
        }

        private void opcionesToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            // Sincroniza la marca de verificación antes de desplegar el menú
            menu_MostrarAnalogico.Checked = m_RelojAnalogico.Visible;
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e) { }


        // =========================================================================
        // 4. COLOR Y FUENTE: Personalización mediante diálogos comunes
        // EXPLICACIÓN: Permite cambiar la apariencia del texto de la hora. Abre las 
        // ventanas típicas de Windows para elegir colores de fondo, color de letras 
        // o tipo de fuente, y aplica esos cambios a la pantalla.
        // =========================================================================
        private void menu_ColorFondo_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            dlgColor.Color = ct_HoraActual.BackColor;
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                ct_HoraActual.BackColor = dlgColor.Color;
            }
        }
        // tanto color de fondo como fuente son modales y se ocultan
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


        // =========================================================================
        // 5. DESPERTADOR Y ALARMA: Encapsulamiento del estado de la alarma
        // EXPLICACIÓN: Controla si la alarma está activa o no. Asegura que la casilla 
        // del formulario y el menú se activen o desactiven a la vez, coordinando 
        // el sonido cuando la hora coincide.
        // =========================================================================
        private bool m_DespertadorActivado = false;

        public bool DespertadorActivado
        {
            get { return m_DespertadorActivado; }
            set
            {
                m_DespertadorActivado = value;
                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;

                // Evita llamadas infinitas al cambiar la casilla si coincide con el estado actual
                if (cv_Despertador.Checked != m_DespertadorActivado)
                {
                    cv_Despertador.Checked = m_DespertadorActivado;
                }
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

        private void cv_Despertador_CheckedChanged(object sender, EventArgs e)
        {
            if (this.DespertadorActivado != cv_Despertador.Checked)
            {
                this.DespertadorActivado = cv_Despertador.Checked;
            }
        }

        private void opcionesDespertador_Click(object sender, EventArgs e) { }

        private void ct_Alarma_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }


        // =========================================================================
        // 6. ZONAS HORARIAS: Gestión dinámica mediante colecciones genéricas (List<T>)
        // EXPLICACIÓN: Administra la lista de países o ciudades añadidos. Permite 
        // crear zonas sin repetir nombres, borrarlas limpiamente de la lista y del 
        // menú, y calcular qué hora es en ese lugar al hacer clic.
        // =========================================================================
        private List<ZonaHoraria> m_Zonas = new List<ZonaHoraria>();

        public int NumeroZonas
        {
            get { return m_Zonas.Count; }
        }

        public List<ZonaHoraria> Zonas
        {
            get { return m_Zonas; }
        }

        // Método refactorizado para añadir una zona horaria al menú desplegable
        private void AñadirOrdenZona(ZonaHoraria zona)
        {
            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            zonaNueva.Text = zona.Nombre;
            zonaNueva.Click += zona_Click;

            menuZona.DropDownItems.Add(zonaNueva);
        }

        private void menuZona_DropDownOpened(object sender, EventArgs e)
        {
            // Habilita/Oculta opciones de menú según la presencia de elementos en la colección
            zonaAñadir.Visible = true;
            zonaEliminar.Visible = (this.NumeroZonas > 0);
            zonaSeparador.Visible = (this.NumeroZonas > 0);
        }

        private void menuContextoZona_Opening(object sender, CancelEventArgs e)
        {
            zonaAñadir.Visible = true;
            zonaEliminar.Visible = (this.NumeroZonas > 0);
            zonaSeparador.Visible = (this.NumeroZonas > 0);
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlgZona = new DlgDatosZona();

            if (dlgZona.ShowDialog() == DialogResult.OK)
            {
                // Validación con predicado anónimo para evitar nombres duplicados en m_Zonas
                bool existe = m_Zonas.Exists(
                    delegate (ZonaHoraria zona)
                    {
                        return zona.Nombre == dlgZona.Nombre;
                    }
                );

                if (existe)
                {
                    MessageBox.Show("Ya existe una zona llamada " + dlgZona.Nombre,
                                    "Zona duplicada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Creación e inserción del nuevo objeto en la lista dinámica
                ZonaHoraria nuevaZona = new ZonaHoraria();
                nuevaZona.Nombre = dlgZona.Nombre;
                nuevaZona.Diferencia = dlgZona.Diferencia;
                nuevaZona.Positivo = dlgZona.Positivo;

                m_Zonas.Add(nuevaZona);

                // Creación dinámica de la opción mediante el método refactorizado
                AñadirOrdenZona(nuevaZona);
            }
        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (this.NumeroZonas <= 0)
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            DlgEliminarZona dlg = new DlgEliminarZona();

            // Invocación modal pasando 'this' como Owner y borrado del índice retornado
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.ZonaSeleccionada != -1)
            {
                int indice = dlg.ZonaSeleccionada;
                string nombreAEliminar = m_Zonas[indice].Nombre;

                // 1. Eliminar de la lista interna
                m_Zonas.RemoveAt(indice);

                // 2. Buscar y eliminar el ítem del menú que tiene ese nombre
                foreach (ToolStripItem item in menuZona.DropDownItems)
                {
                    if (item.Text == nombreAEliminar)
                    {
                        menuZona.DropDownItems.Remove(item);
                        break;
                    }
                }
            }
        }

        private void zona_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                string nombreZona = item.Text;

                // Recuperar la zona horaria de la colección m_Zonas mediante el predicado anónimo
                ZonaHoraria zonaSeleccionada = m_Zonas.Find(
                    delegate (ZonaHoraria zona)
                    {
                        return zona.Nombre == nombreZona;
                    }
                );

                if (zonaSeleccionada != null)
                {
                    // Calcular la hora correspondiente a la zona
                    DateTime horaActual = DateTime.Now + m_DesfaseHorario;
                    DateTime horaZona = zonaSeleccionada.Positivo
                        ? horaActual + zonaSeleccionada.Diferencia
                        : horaActual - zonaSeleccionada.Diferencia;

                    // Mostrar la caja de mensaje con el nombre y la hora
                    MessageBox.Show("Zona: " + zonaSeleccionada.Nombre + "\nHora: " + horaZona.ToLongTimeString(),
                                    "Zona seleccionada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
        }

        private void menuZona_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }


        // =========================================================================
        // 7. SERIALIZACIÓN: Persistencia de datos (Guardar al cerrar y cargar al abrir)
        // EXPLICACIÓN: Se encarga de la memoria permanente. Guarda la lista de zonas 
        // horarias en un archivo de datos ("reloj.dat") al cerrar el programa y las 
        // vuelve a leer automáticamente al arrancarlo de nuevo.
        // =========================================================================
        private void RelojDigital_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream stream = File.Open("reloj.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, m_Zonas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear el archivo de zonas. Causa: " + ex.Message);
            }
        }
    }
}