namespace P1_Reloj
{
    partial class DlgDatosZona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ct_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Positivo = new System.Windows.Forms.RadioButton();
            this.rb_Negativo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.ct_Diferencia = new P1_Reloj.EditHora();
            this.SuspendLayout();
            // 
            // ct_Nombre
            // 
            this.ct_Nombre.Location = new System.Drawing.Point(221, 189);
            this.ct_Nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ct_Nombre.Name = "ct_Nombre";
            this.ct_Nombre.Size = new System.Drawing.Size(419, 26);
            this.ct_Nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diferencia horaria:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rb_Positivo
            // 
            this.rb_Positivo.AutoSize = true;
            this.rb_Positivo.Checked = true;
            this.rb_Positivo.Location = new System.Drawing.Point(552, 295);
            this.rb_Positivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_Positivo.Name = "rb_Positivo";
            this.rb_Positivo.Size = new System.Drawing.Size(88, 24);
            this.rb_Positivo.TabIndex = 6;
            this.rb_Positivo.TabStop = true;
            this.rb_Positivo.Text = "Positivo";
            this.rb_Positivo.UseVisualStyleBackColor = true;
            // 
            // rb_Negativo
            // 
            this.rb_Negativo.AutoSize = true;
            this.rb_Negativo.Location = new System.Drawing.Point(552, 327);
            this.rb_Negativo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_Negativo.Name = "rb_Negativo";
            this.rb_Negativo.Size = new System.Drawing.Size(96, 24);
            this.rb_Negativo.TabIndex = 7;
            this.rb_Negativo.TabStop = true;
            this.rb_Negativo.Text = "Negativo";
            this.rb_Negativo.UseVisualStyleBackColor = true;
            this.rb_Negativo.CheckedChanged += new System.EventHandler(this.rb_Negativo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Signo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(729, 168);
            this.bt_Aceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(84, 29);
            this.bt_Aceptar.TabIndex = 8;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click_1);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancelar.Location = new System.Drawing.Point(729, 206);
            this.bt_Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(84, 29);
            this.bt_Cancelar.TabIndex = 9;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // ct_Diferencia
            // 
            this.ct_Diferencia.BeepOnError = true;
            this.ct_Diferencia.Hora = new System.DateTime(((long)(0)));
            this.ct_Diferencia.Location = new System.Drawing.Point(305, 296);
            this.ct_Diferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ct_Diferencia.Mask = "90:00:99";
            this.ct_Diferencia.Name = "ct_Diferencia";
            this.ct_Diferencia.PromptChar = '-';
            this.ct_Diferencia.Size = new System.Drawing.Size(112, 26);
            this.ct_Diferencia.TabIndex = 4;
            this.ct_Diferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Diferencia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // DlgDatosZona
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancelar;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_Negativo);
            this.Controls.Add(this.rb_Positivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ct_Diferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DlgDatosZona";
            this.Text = "Datos de zona horaria";
            this.Load += new System.EventHandler(this.DlgDatosZona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ct_Nombre;
        private System.Windows.Forms.Label label2;
        private EditHora ct_Diferencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_Positivo;
        private System.Windows.Forms.RadioButton rb_Negativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}