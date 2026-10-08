namespace P1_Reloj
{
    partial class RelojDigital
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuContextoZona = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zonaAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MostrarAnalogico = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ColorFondo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ColorTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fuente = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesDespertador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextoAlarma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpcionesDespertadorActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesDespertadorDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZona = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ct_Alarma = new P1_Reloj.EditHora();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cv_Despertador = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menuContextoZona.SuspendLayout();
            this.menuContextoAlarma.SuspendLayout();
            this.SuspendLayout();
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.Location = new System.Drawing.Point(145, 112);
            this.ct_HoraActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(288, 22);
            this.ct_HoraActual.TabIndex = 1;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hora actual:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.menuContextoZona;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.menuZona});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(606, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, "Añada/elimine una zona pulsando el botón derecho del ratón\r\n");
            // 
            // menuContextoZona
            // 
            this.menuContextoZona.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuContextoZona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonaAñadir,
            this.zonaEliminar,
            this.zonaSeparador});
            this.menuContextoZona.Name = "menuContextoAlarma";
            this.menuContextoZona.OwnerItem = this.menuZona;
            this.menuContextoZona.Size = new System.Drawing.Size(125, 58);
            this.menuContextoZona.Opening += new System.ComponentModel.CancelEventHandler(this.menuContextoZona_Opening);
            this.menuContextoZona.Opened += new System.EventHandler(this.menuZona_DropDownOpened);
            // 
            // zonaAñadir
            // 
            this.zonaAñadir.Name = "zonaAñadir";
            this.zonaAñadir.Size = new System.Drawing.Size(124, 24);
            this.zonaAñadir.Text = "Añadir";
            this.zonaAñadir.Click += new System.EventHandler(this.zonaAñadir_Click);
            // 
            // zonaEliminar
            // 
            this.zonaEliminar.Name = "zonaEliminar";
            this.zonaEliminar.Size = new System.Drawing.Size(124, 24);
            this.zonaEliminar.Text = "Elimiar";
            this.zonaEliminar.Click += new System.EventHandler(this.zonaEliminar_Click);
            // 
            // zonaSeparador
            // 
            this.zonaSeparador.Name = "zonaSeparador";
            this.zonaSeparador.Size = new System.Drawing.Size(121, 6);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_MostrarAnalogico,
            this.menu_ColorFondo,
            this.menu_ColorTexto,
            this.menu_Fuente,
            this.opcionesDespertador});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.DropDownOpened += new System.EventHandler(this.opcionesToolStripMenuItem_DropDownOpened);
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // menu_MostrarAnalogico
            // 
            this.menu_MostrarAnalogico.Name = "menu_MostrarAnalogico";
            this.menu_MostrarAnalogico.Size = new System.Drawing.Size(271, 26);
            this.menu_MostrarAnalogico.Text = "Mostrar/ Ocultar analógico";
            this.menu_MostrarAnalogico.Click += new System.EventHandler(this.menu_MostrarAnalogico_Click);
            // 
            // menu_ColorFondo
            // 
            this.menu_ColorFondo.Name = "menu_ColorFondo";
            this.menu_ColorFondo.Size = new System.Drawing.Size(271, 26);
            this.menu_ColorFondo.Text = "Color de fondo";
            this.menu_ColorFondo.Click += new System.EventHandler(this.menu_ColorFondo_Click);
            // 
            // menu_ColorTexto
            // 
            this.menu_ColorTexto.Name = "menu_ColorTexto";
            this.menu_ColorTexto.Size = new System.Drawing.Size(271, 26);
            this.menu_ColorTexto.Text = "Color de texto";
            this.menu_ColorTexto.Click += new System.EventHandler(this.menu_ColorTexto_Click);
            // 
            // menu_Fuente
            // 
            this.menu_Fuente.Name = "menu_Fuente";
            this.menu_Fuente.Size = new System.Drawing.Size(271, 26);
            this.menu_Fuente.Text = "Fuente";
            this.menu_Fuente.Click += new System.EventHandler(this.menu_Fuente_Click);
            // 
            // opcionesDespertador
            // 
            this.opcionesDespertador.DropDown = this.menuContextoAlarma;
            this.opcionesDespertador.Name = "opcionesDespertador";
            this.opcionesDespertador.Size = new System.Drawing.Size(271, 26);
            this.opcionesDespertador.Text = "Despertador";
            this.opcionesDespertador.Click += new System.EventHandler(this.opcionesDespertador_Click);
            // 
            // menuContextoAlarma
            // 
            this.menuContextoAlarma.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuContextoAlarma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesDespertadorActivar,
            this.OpcionesDespertadorDesactivar});
            this.menuContextoAlarma.Name = "menuContextoAlarma";
            this.menuContextoAlarma.OwnerItem = this.opcionesDespertador;
            this.menuContextoAlarma.Size = new System.Drawing.Size(148, 52);
            // 
            // OpcionesDespertadorActivar
            // 
            this.OpcionesDespertadorActivar.Name = "OpcionesDespertadorActivar";
            this.OpcionesDespertadorActivar.Size = new System.Drawing.Size(147, 24);
            this.OpcionesDespertadorActivar.Text = "Activar";
            this.OpcionesDespertadorActivar.Click += new System.EventHandler(this.opcionesDespertadorActivar_Click);
            // 
            // OpcionesDespertadorDesactivar
            // 
            this.OpcionesDespertadorDesactivar.Enabled = false;
            this.OpcionesDespertadorDesactivar.Name = "OpcionesDespertadorDesactivar";
            this.OpcionesDespertadorDesactivar.Size = new System.Drawing.Size(147, 24);
            this.OpcionesDespertadorDesactivar.Text = "Desactivar";
            this.OpcionesDespertadorDesactivar.Click += new System.EventHandler(this.opcionesDespertadorDesactivar_Click);
            // 
            // menuZona
            // 
            this.menuZona.DropDown = this.menuContextoZona;
            this.menuZona.Name = "menuZona";
            this.menuZona.Size = new System.Drawing.Size(57, 24);
            this.menuZona.Text = "Zona";
            this.menuZona.DropDownOpened += new System.EventHandler(this.menuZona_DropDownOpened);
            this.menuZona.Click += new System.EventHandler(this.menuZona_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alarma:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ct_Alarma
            // 
            this.ct_Alarma.BackColor = System.Drawing.Color.LightSalmon;
            this.ct_Alarma.BeepOnError = true;
            this.ct_Alarma.ForeColor = System.Drawing.SystemColors.Window;
            this.ct_Alarma.Hora = new System.DateTime(((long)(0)));
            this.ct_Alarma.Location = new System.Drawing.Point(235, 228);
            this.ct_Alarma.Mask = "90:00:99";
            this.ct_Alarma.Name = "ct_Alarma";
            this.ct_Alarma.PromptChar = '-';
            this.ct_Alarma.Size = new System.Drawing.Size(110, 22);
            this.ct_Alarma.TabIndex = 4;
            this.ct_Alarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Alarma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // cv_Despertador
            // 
            this.cv_Despertador.AutoSize = true;
            this.cv_Despertador.Location = new System.Drawing.Point(252, 150);
            this.cv_Despertador.Name = "cv_Despertador";
            this.cv_Despertador.Size = new System.Drawing.Size(161, 20);
            this.cv_Despertador.TabIndex = 6;
            this.cv_Despertador.Text = "Despertador Activado";
            this.cv_Despertador.UseVisualStyleBackColor = true;
            this.cv_Despertador.CheckedChanged += new System.EventHandler(this.cv_Despertador_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "DlgEliminarZona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cv_Despertador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Alarma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RelojDigital";
            this.Text = "Reloj digital";
            this.Load += new System.EventHandler(this.RelojDigital_Load);
            this.Shown += new System.EventHandler(this.RelojDigital_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuContextoZona.ResumeLayout(false);
            this.menuContextoAlarma.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ct_HoraActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_MostrarAnalogico;
        private System.Windows.Forms.ToolStripMenuItem menu_ColorFondo;
        private System.Windows.Forms.ToolStripMenuItem menu_ColorTexto;
        private System.Windows.Forms.ToolStripMenuItem menu_Fuente;
        private EditHora ct_Alarma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem menuZona;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip menuContextoAlarma;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorActivar;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorDesactivar;
        private System.Windows.Forms.ToolStripMenuItem opcionesDespertador;
        private System.Windows.Forms.ContextMenuStrip menuContextoZona;
        private System.Windows.Forms.ToolStripMenuItem zonaAñadir;
        private System.Windows.Forms.ToolStripMenuItem zonaEliminar;
        private System.Windows.Forms.ToolStripSeparator zonaSeparador;
        private System.Windows.Forms.CheckBox cv_Despertador;
        private System.Windows.Forms.Button button1;
    }
}

