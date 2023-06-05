namespace ORUSCURSO.Presentacion
{
    partial class copiasBD
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel12
            // 
            this.Panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.Panel12.Controls.Add(this.Label1);
            this.Panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel12.Location = new System.Drawing.Point(0, 0);
            this.Panel12.Margin = new System.Windows.Forms.Padding(4);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(850, 55);
            this.Panel12.TabIndex = 615;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(4, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(243, 29);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Copia de seguridad";
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.White;
            this.txtRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRuta.Enabled = false;
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRuta.Location = new System.Drawing.Point(87, 117);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(539, 30);
            this.txtRuta.TabIndex = 618;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label3.ForeColor = System.Drawing.Color.Gray;
            this.Label3.Location = new System.Drawing.Point(83, 166);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(499, 60);
            this.Label3.TabIndex = 616;
            this.Label3.Text = "Guarda copias de Seguridad de la base de datos para no perder \r\nningun Dato de tu" +
    " Empresa. Podras recuperar toda la Informacion\r\nen caso Tu PC tenga algun proble" +
    "ma";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label2.Location = new System.Drawing.Point(82, 83);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(357, 29);
            this.Label2.TabIndex = 617;
            this.Label2.Text = "Ruta de Copias de Seguridad";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(171)))), ((int)(((byte)(55)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Location = new System.Drawing.Point(87, 264);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(540, 53);
            this.btnGenerar.TabIndex = 619;
            this.btnGenerar.Text = "Generar Copia ahora mismo";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ORUSCURSO.Properties.Resources.buscar__1_;
            this.pictureBox1.Location = new System.Drawing.Point(35, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 620;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // copiasBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.Panel12);
            this.Name = "copiasBD";
            this.Size = new System.Drawing.Size(850, 351);
            this.Load += new System.EventHandler(this.copiasBD_Load);
            this.Panel12.ResumeLayout(false);
            this.Panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel12;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtRuta;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
