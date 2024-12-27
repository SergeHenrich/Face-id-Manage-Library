using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ProjetGroupe5
{
    public partial class StockLivres : Form
    {
        LivreDAL liv = new LivreDAL();
        LivreBLL livb = new LivreBLL();
        public StockLivres()
        {
            InitializeComponent();
        }
        #region Form LoadStock
        private void StockLivres_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
        #region Retour
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Emprunt em = new Emprunt();
            em.Show();
            this.Hide();
        }
        #endregion
        #region LoadData
        private void LoadData()
        {
            DataTable dt = liv.livrestock(livb);
            dvgLivres.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dvgLivres.Rows.Add();
                dvgLivres.Rows[n].Cells["LivresID"].Value = item["LivreID"].ToString();
                dvgLivres.Rows[n].Cells["Code"].Value = item["code"].ToString();
                dvgLivres.Rows[n].Cells["nom"].Value = item["nom"].ToString();
                dvgLivres.Rows[n].Cells["auteur"].Value = item["auteur"].ToString();
                dvgLivres.Rows[n].Cells["NombrePages"].Value = int.Parse(item["NPages"].ToString());
                dvgLivres.Rows[n].Cells["AnneePublication"].Value = item["APublic"].ToString();
                dvgLivres.Rows[n].Cells["Disponibilité"].Value = item["IsAvailable"].ToString();
            }
        }
        #endregion

        
    }
}
