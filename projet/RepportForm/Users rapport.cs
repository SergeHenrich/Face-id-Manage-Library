using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjetGroupe5.RepportForm
{
    public partial class Users_rapport : Form

    {
         UtilisateurDAL ba = new  UtilisateurDAL();
        UtilisateurBLL da = new UtilisateurBLL();
        ReportDocument rpt = new ReportDocument();
        public Users_rapport()
        {
            InitializeComponent();
        }

        private void Users_rapport_Load(object sender, EventArgs e)
        {
            string cheminRapport = System.IO.Path.Combine(Application.StartupPath, "repport", "CrystalReportuser.rpt");
            rpt.Load(cheminRapport);
            DataTable dt = ba.selectuser(da);
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
