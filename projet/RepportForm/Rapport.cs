using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjetGroupe5.RepportForm
{
    public partial class Rapport : Form
    {
        LivreDAL ba = new LivreDAL();
        LivreBLL da = new  LivreBLL();
        ReportDocument rpt = new ReportDocument();
        public Rapport()
        {
            InitializeComponent();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            string cheminRapport = System.IO.Path.Combine(Application.StartupPath, "repport", "CrystalReport1.rpt");
            rpt.Load(cheminRapport);
            DataTable dt = ba.selectLivres(da);
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;

        }
    }
}
