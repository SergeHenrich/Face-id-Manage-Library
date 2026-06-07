using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ProjetGroupe5
{
    public partial class Emprunt : Form
    {
        LivreDAL ldal = new LivreDAL();
        LivreBLL lbll = new LivreBLL();
        UtilisateurBLL ubll = new UtilisateurBLL();
        UtilisateurDAL udal = new UtilisateurDAL();
        EmpruntBLL ebll = new EmpruntBLL();
        EmpruntDAL edal = new EmpruntDAL();

        public Emprunt()
        {
            InitializeComponent();
            LoadData();
        }
        #region QuitterApplication
        private void lblQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
        #region Retour
        private void btnRetour_Click(object sender, EventArgs e)
        {
            ConnexionUtilisateur cu = new ConnexionUtilisateur();
            cu.Show();
            this.Hide();
            lbll.codeLiv = txtCodeLiv.Text;
            
        }

        #endregion
        #region Emprunter
        private void btnEmprunter_Click(object sender, EventArgs e)
        {
            lbll.codeLiv = txtCodeLiv.Text;
            string code = lbll.codeLiv;
            ubll.id = int.Parse(txtMat.Text);
            int id = ubll.id;
            ebll.dateEmprunt = DateTime.Parse(dtp1.Value.ToString());
            ebll.dateRetour = DateTime.Parse(dtp2.Value.ToString());
            try
            {
                if(ubll.id ==0 || string.IsNullOrEmpty(lbll.codeLiv) || string.IsNullOrEmpty(ebll.dateEmprunt.ToString()) || string.IsNullOrEmpty(ebll.dateRetour.ToString()))
                {
                    MessageBox.Show("Veuillez remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if(ebll.dateEmprunt > DateTime.Now || ebll.dateRetour < ebll.dateEmprunt)
                    {
                        MessageBox.Show("Veuillez entrer une date valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int lid = ldal.GetLivresIDbyCodes(code); 
                    edal.BorrowBookByCode(id, code, ebll);
                    ldal.SetStatus(lid);
                                      
                    MessageBox.Show("Emprunt réussie avec succés");
                    LoadData();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Aucune données n'a été charger" + ex.Message);
            }
            
        }
        #endregion
        #region LoadData
        private void LoadData()
        {
            DataTable dt = edal.selectEmprunt(ebll);
            dtEmprunt.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dtEmprunt.Rows.Add();
                dtEmprunt.Rows[n].Cells["IdEmprunt"].Value = item["EId"].ToString();
                dtEmprunt.Rows[n].Cells["IdUsers"].Value = item["UsersID"].ToString();
                dtEmprunt.Rows[n].Cells["IdLIv"].Value = item["BookID"].ToString();
                dtEmprunt.Rows[n].Cells["DateEmprunt"].Value = DateTime.Parse(item["DatePrêt"].ToString());
                dtEmprunt.Rows[n].Cells["DateRetour"].Value = DateTime.Parse(item["DateRetour"].ToString());
            }
        }
        #endregion
        #region VoirStock
        private void btnVoirStock_Click(object sender, EventArgs e)
        {
            StockLivres sl = new StockLivres();
            sl.Show();
            this.Hide();
        }
        #endregion
        #region FormLoad Emprunt
        private void Emprunt_Load(object sender, EventArgs e)
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.son4);
            play.Play();
            LoadData();
        }
        #endregion

    }
}
