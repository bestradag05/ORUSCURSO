namespace ORUSCURSO.Presentacion.AsistenteInstalacion
{
    partial class InstalacionBd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label66 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInstalarServidor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Label66);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 75);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ORUSCURSO.Properties.Resources.MonoOrus;
            this.pictureBox1.Location = new System.Drawing.Point(101, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 602;
            this.pictureBox1.TabStop = false;
            // 
            // Label66
            // 
            this.Label66.BackColor = System.Drawing.Color.Transparent;
            this.Label66.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label66.ForeColor = System.Drawing.Color.White;
            this.Label66.Location = new System.Drawing.Point(0, 0);
            this.Label66.Name = "Label66";
            this.Label66.Size = new System.Drawing.Size(101, 75);
            this.Label66.TabIndex = 601;
            this.Label66.Text = "Orus 369";
            this.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnInstalarServidor);
            this.panel2.Location = new System.Drawing.Point(360, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 519);
            this.panel2.TabIndex = 2;
            // 
            // btnInstalarServidor
            // 
            this.btnInstalarServidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnInstalarServidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstalarServidor.FlatAppearance.BorderSize = 0;
            this.btnInstalarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstalarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.btnInstalarServidor.ForeColor = System.Drawing.Color.White;
            this.btnInstalarServidor.Location = new System.Drawing.Point(44, 15);
            this.btnInstalarServidor.Name = "btnInstalarServidor";
            this.btnInstalarServidor.Size = new System.Drawing.Size(413, 84);
            this.btnInstalarServidor.TabIndex = 611;
            this.btnInstalarServidor.Text = "Instalar Servidor";
            this.btnInstalarServidor.UseVisualStyleBackColor = false;
            this.btnInstalarServidor.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(1, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 402);
            this.panel3.TabIndex = 612;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(481, 13);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 153);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instalando Servidor...\r\n\r\nNo cierre esta ventana, se cerrara automaticamente cuan" +
    "do este todo listo\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstalacionBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1172, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InstalacionBd";
            this.Text = "InstalacionBd";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label66;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Button btnInstalarServidor;
    }
}