using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORUSCURSO.Datos;

namespace ORUSCURSO.Presentacion
{
    public partial class Preplanilla : UserControl
    {
        public Preplanilla()
        {
            InitializeComponent();
        }

        private void Preplanilla_Load(object sender, EventArgs e)
        {
            calcular_numero_de_Semana();
        }

        public void ReporteAsistencias()
        {
            Reportes.ReportAsistencias rpt = new Reportes.ReportAsistencias();
            DataTable dt = new DataTable();
            Dasistencias funcion = new Dasistencias();
            funcion.mostrar_asistencias_diarias(ref dt, txtdesde.Value, txthasta.Value, Convert.ToInt32(lblnumerosemana.Text));
            rpt.DataSource = dt;
            rpt.table1.DataSource = dt;
            rpt.SkipBlankPages = false;


            reportViewer1.Report = rpt;
            reportViewer1.RefreshReport();
        }

        private void txtdesde_ValueChanged(object sender, EventArgs e)
        {
            calcular_numero_de_Semana();
            ReporteAsistencias();
        }

        private void calcular_numero_de_Semana()
        {
            DateTime v2 = txthasta.Value;
            lblnumerosemana.Text = CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(v2, CalendarWeekRule.FirstDay, v2.DayOfWeek).ToString();
        }

        private void txthasta_ValueChanged(object sender, EventArgs e)
        {
            calcular_numero_de_Semana();
            ReporteAsistencias();
        }
    }
}
