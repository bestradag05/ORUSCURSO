namespace ORUSCURSO.Presentacion
{
    partial class TomarAsistencias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TomarAsistencias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIniciarSecion = new System.Windows.Forms.Button();
            this.Label66 = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.txtaviso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.panelObservacion = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegistro.SuspendLayout();
            this.panelObservacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnIniciarSecion);
            this.panel1.Controls.Add(this.Label66);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1787, 62);
            this.panel1.TabIndex = 0;
            // 
            // BtnIniciarSecion
            // 
            this.BtnIniciarSecion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.BtnIniciarSecion.BackgroundImage = global::ORUSCURSO.Properties.Resources.naranja;
            this.BtnIniciarSecion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIniciarSecion.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnIniciarSecion.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnIniciarSecion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSecion.Location = new System.Drawing.Point(1524, 0);
            this.BtnIniciarSecion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIniciarSecion.Name = "BtnIniciarSecion";
            this.BtnIniciarSecion.Size = new System.Drawing.Size(263, 62);
            this.BtnIniciarSecion.TabIndex = 601;
            this.BtnIniciarSecion.Text = "Iniciar Secion";
            this.BtnIniciarSecion.UseVisualStyleBackColor = false;
            this.BtnIniciarSecion.Click += new System.EventHandler(this.BtnIniciarSecion_Click);
            // 
            // Label66
            // 
            this.Label66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Label66.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label66.ForeColor = System.Drawing.Color.White;
            this.Label66.Location = new System.Drawing.Point(0, 0);
            this.Label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(135, 62);
            this.Label66.TabIndex = 600;
            this.Label66.Text = "Orus 369";
            this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label66.Click += new System.EventHandler(this.Label66_Click);
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.Color.White;
            this.texto.Location = new System.Drawing.Point(75, 375);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(206, 36);
            this.texto.TabIndex = 0;
            this.texto.Text = "Identificacion: ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(171, 476);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 36);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Fecha:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(171, 537);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(87, 36);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.lblFecha.Location = new System.Drawing.Point(292, 476);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 36);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DimGray;
            this.lblHora.Location = new System.Drawing.Point(292, 537);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(79, 36);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(283, 401);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 1);
            this.panel3.TabIndex = 464;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(283, 362);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(437, 34);
            this.txtIdentificacion.TabIndex = 463;
            this.txtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ORUSCURSO.Properties.Resources.MonoOrus;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 465;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 36);
            this.label1.TabIndex = 466;
            this.label1.Text = "REGISTRO DE ASISTENCIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.txtaviso);
            this.panelRegistro.Controls.Add(this.txtNombre);
            this.panelRegistro.Controls.Add(this.label1);
            this.panelRegistro.Controls.Add(this.pictureBox1);
            this.panelRegistro.Controls.Add(this.txtIdentificacion);
            this.panelRegistro.Controls.Add(this.panel3);
            this.panelRegistro.Controls.Add(this.lblHora);
            this.panelRegistro.Controls.Add(this.lblFecha);
            this.panelRegistro.Controls.Add(this.lbl2);
            this.panelRegistro.Controls.Add(this.lbl1);
            this.panelRegistro.Controls.Add(this.texto);
            this.panelRegistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelRegistro.Location = new System.Drawing.Point(627, 118);
            this.panelRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(777, 852);
            this.panelRegistro.TabIndex = 1;
            this.panelRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtaviso
            // 
            this.txtaviso.BackColor = System.Drawing.Color.Transparent;
            this.txtaviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.txtaviso.Location = new System.Drawing.Point(52, 614);
            this.txtaviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtaviso.Name = "txtaviso";
            this.txtaviso.Size = new System.Drawing.Size(667, 36);
            this.txtaviso.TabIndex = 468;
            this.txtaviso.Text = "********";
            this.txtaviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.Location = new System.Drawing.Point(52, 650);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(667, 47);
            this.txtNombre.TabIndex = 467;
            this.txtNombre.Text = "***";
            this.txtNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelObservacion
            // 
            this.panelObservacion.Controls.Add(this.btnConfirmar);
            this.panelObservacion.Controls.Add(this.txtObservacion);
            this.panelObservacion.Controls.Add(this.lblObservaciones);
            this.panelObservacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelObservacion.Location = new System.Drawing.Point(208, 118);
            this.panelObservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelObservacion.Name = "panelObservacion";
            this.panelObservacion.Size = new System.Drawing.Size(332, 615);
            this.panelObservacion.TabIndex = 2;
            this.panelObservacion.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackgroundImage = global::ORUSCURSO.Properties.Resources.azul;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(5, 246);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirmar.Size = new System.Drawing.Size(184, 55);
            this.btnConfirmar.TabIndex = 612;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.White;
            this.txtObservacion.Location = new System.Drawing.Point(0, 33);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(332, 189);
            this.txtObservacion.TabIndex = 1;
            this.txtObservacion.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.White;
            this.lblObservaciones.Location = new System.Drawing.Point(0, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(332, 33);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Oberservaciones";
            this.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // TomarAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1787, 905);
            this.Controls.Add(this.panelObservacion);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TomarAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TomarAsistencias_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.panelObservacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label Label66;
        private System.Windows.Forms.Button BtnIniciarSecion;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegistro;
        internal System.Windows.Forms.Label txtaviso;
        internal System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Panel panelObservacion;
        private System.Windows.Forms.RichTextBox txtObservacion;
        private System.Windows.Forms.Label lblObservaciones;
        internal System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Timer timerHora;
    }
}