namespace ORUSCURSO.Presentacion
{
    partial class Preplanilla
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnumerosemana = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txthasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.lblnumerosemana);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.txthasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtdesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 206);
            this.panel1.TabIndex = 0;
            // 
            // lblnumerosemana
            // 
            this.lblnumerosemana.AutoSize = true;
            this.lblnumerosemana.BackColor = System.Drawing.Color.Transparent;
            this.lblnumerosemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblnumerosemana.ForeColor = System.Drawing.Color.White;
            this.lblnumerosemana.Location = new System.Drawing.Point(595, 112);
            this.lblnumerosemana.Name = "lblnumerosemana";
            this.lblnumerosemana.Size = new System.Drawing.Size(24, 25);
            this.lblnumerosemana.TabIndex = 602;
            this.lblnumerosemana.Text = "#";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(461, 112);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(128, 25);
            this.Label7.TabIndex = 601;
            this.Label7.Text = "Semana Nº:";
            // 
            // txthasta
            // 
            this.txthasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthasta.Checked = false;
            this.txthasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthasta.Location = new System.Drawing.Point(316, 111);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(111, 26);
            this.txthasta.TabIndex = 3;
            this.txthasta.ValueChanged += new System.EventHandler(this.txthasta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "al";
            // 
            // txtdesde
            // 
            this.txtdesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesde.Checked = false;
            this.txtdesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdesde.Location = new System.Drawing.Point(86, 111);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(111, 26);
            this.txtdesde.TabIndex = 1;
            this.txtdesde.ValueChanged += new System.EventHandler(this.txtdesde_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Del";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 206);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1232, 434);
            this.reportViewer1.TabIndex = 613;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // Preplanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "Preplanilla";
            this.Size = new System.Drawing.Size(1232, 640);
            this.Load += new System.EventHandler(this.Preplanilla_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblnumerosemana;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.DateTimePicker txthasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtdesde;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}
