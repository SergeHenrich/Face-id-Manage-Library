using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using BL;
namespace ProjetGroupe5
{
    public partial class Gestionnaires : Form
    {
        LivreBLL livB = new LivreBLL();
        LivreDAL livd = new LivreDAL();

        public Gestionnaires()
        {
            InitializeComponent();
           
        }

        #region Retour
        private void btnRetour_Click(object sender, EventArgs e)
        {
            ConnexionAdmin ca = new ConnexionAdmin();
            ca.Show();
            this.Hide();
        }
        #endregion

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

        #region Boutton Ajouter
        private void btnAjouterLiv_Click(object sender, EventArgs e)
        {
            livB.nomLiv = txtNomliv.Text;
            livB.auteurLiv = txtAuteur.Text;
            livB.codeLiv = txtCodeliv.Text;
            livB.Available = cmbStatus.SelectedItem?.ToString();
            livB.APublic = txtAPublic.Text;
            livB.NPages = txtNPages.Text;

            if (string.IsNullOrEmpty(livB.nomLiv) || string.IsNullOrEmpty(livB.codeLiv) || string.IsNullOrEmpty(livB.APublic) || string.IsNullOrEmpty(livB.auteurLiv)|| string.IsNullOrEmpty(livB.Available)|| string.IsNullOrEmpty(livB.NPages))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAPublic.Text.Length < 4 || txtAPublic.Text.Length > 4)
            {
                MessageBox.Show(" la date que vous avez entré est invalide");
                txtAPublic.Clear();
            }

            else
            {
                if (livd != null && livd.Livresexist(livB))
                {
                    MessageBox.Show("Desolé ce livre existe deja dans  la base de données ");
                    txtCodeliv.Clear();
                }
                else
                {
                    try
                    {
                        livd.AddLivres(livB);
                        MessageBox.Show(" Livre enregistré avec succès", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        txtAPublic.Text = "";
                        txtAuteur.Text = "";
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show("Echec d'enregistrement!" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                 // appelle la methode clear form pour effacer les champs
                    LoadData(); // raffraichit les données  affichées dans l'interface
                    DisplayAvailableBooksInLabel(lblNbreDispo);
                    DisplayUnavailableInLabel(lblNbreEmprunter);
                }
            }
        }

        #endregion

        #region Bouutton Modifier
        private void btnModifierLiv_Click(object sender, EventArgs e)
        {
            livB.nomLiv = txtNomliv.Text;
            livB.codeLiv = txtCodeliv.Text;
            livB.auteurLiv = txtAuteur.Text;
            livB.Available = cmbStatus.Text;
            livB.APublic = txtAPublic.Text;
            livB.NPages = txtNPages.Text;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez selectionner un livre a mettre a jour !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            // mettre a jour le produit dans la base de donnée 
            try
            {
                // la methode productulivBte est appéllé avec la valeur du statut 
                // pour que la methode pisse acceder a la valeur du statut
                //   livd.productulivBte(livB, status);
                // affiche un message de succès 
                livd.UpdateBook(livB);
                MessageBox.Show("livre mis a  jour avec succes", "succès", MessageBoxButtons.OK, MessageBoxIcon.None);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification" + ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuteur.Text = "";
                txtAPublic.Text = "";
            }
            DisplayAvailableBooksInLabel(lblNbreDispo);
            DisplayUnavailableInLabel(lblNbreEmprunter);
            LoadData();
            ClearForm();
        }

        #endregion

        #region Boutton Supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez selectionner un livre a supprimer", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            livB.codeLiv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer ce livre", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                livd.livredelete(livB);
                MessageBox.Show("livre supprimé avec succes", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayAvailableBooksInLabel(lblNbreDispo);
                DisplayUnavailableInLabel(lblNbreEmprunter);
                ClearForm();// appelle la methode clear form pour effacer les champs
                            // LoadData(); // raffraichit les données  affichées dans l'interface
                            // dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                LoadData();
            }
        }

        #endregion

        #region ClearForm
        private void ClearForm()
        {
            txtCodeliv.Clear();
            txtNomliv.Clear();
            txtNPages.Clear();
            cmbStatus.SelectedIndex = 0;
        }

        #endregion

        #region LoadData
        private void LoadData()
        {
            DataTable dt = livd.selectLivres(livB);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Code"].Value = item["code"].ToString();
                dataGridView1.Rows[n].Cells["Nom"].Value = item["nom"].ToString();
                dataGridView1.Rows[n].Cells["Auteur"].Value = item["auteur"].ToString();
                dataGridView1.Rows[n].Cells["NbrePages"].Value = item["NPages"].ToString();
                dataGridView1.Rows[n].Cells["AnneePublication"].Value = item["APublic"].ToString();
                dataGridView1.Rows[n].Cells["Status"].Value = item["IsAvailable"].ToString();
            }
        }
        #endregion

        #region DisplayAvailableBooksInLabel
        public void DisplayAvailableBooksInLabel(Label label)
        {
            int availableBooksCount = livd.GetAvailableBooksCount();
            label.Text = availableBooksCount.ToString();
        }
        #endregion

        #region DisplayUnavailableInLabel
        public void DisplayUnavailableInLabel(Label label)
        {
            int unavailableCount = livd.GetUnavailableBooksCount();
            label.Text = unavailableCount.ToString();
        }
        #endregion

        #region FormLoad Gestionnaires
        private void Gestionnaires_Load(object sender, EventArgs e)
        {
            LoadData();
            DisplayAvailableBooksInLabel(lblNbreDispo);
            DisplayUnavailableInLabel(lblNbreEmprunter);
        }
        #endregion

        #region Hover Boutton
        private void btnRapport_Click(object sender, EventArgs e)
        {
            RepportForm.Rapport prd = new  RepportForm.Rapport();
            prd.StartPosition = FormStartPosition.CenterScreen;
            prd.Show();
            //this.Hide();
        }

        private void txtAPublic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAjouterLiv_MouseHover(object sender, EventArgs e)
        {
            btnAjouterLiv.BackColor = Color.Green;
            btnAjouterLiv.ForeColor = Color.White;
        }

        private void btnAjouterLiv_MouseLeave(object sender, EventArgs e)
        {
            btnAjouterLiv.BackColor = Color.FromArgb(40, 100, 120);
            btnAjouterLiv.ForeColor = Color.White;
        }

        private void btnModifierLiv_MouseHover(object sender, EventArgs e)
        {
            btnModifierLiv.BackColor = Color.Green;
            btnModifierLiv.ForeColor = Color.White;
        }

        private void btnModifierLiv_MouseLeave(object sender, EventArgs e)
        {
            btnModifierLiv.BackColor = Color.FromArgb(40, 100, 120);
            btnModifierLiv.ForeColor = Color.White;
        }

        private void btnSupprimer_MouseHover(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.Green;
            btnSupprimer.ForeColor = Color.White;
        }

        private void btnSupprimer_MouseLeave(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = Color.FromArgb(40, 100, 120);
            btnSupprimer.ForeColor = Color.White;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                         txtCodeliv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        txtNomliv.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        txtAuteur.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                         txtNPages.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        txtAPublic.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Disponible")
                {
                    cmbStatus.SelectedIndex = 0;
                }
                else
                {
                    cmbStatus.SelectedIndex = 1;
                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepportForm.Users_rapport prd = new RepportForm.Users_rapport();
            prd.StartPosition = FormStartPosition.CenterScreen;
            prd.Show();
        }

        private void btnRapport_MouseHover(object sender, EventArgs e)
        {
            btnRapport.BackColor = Color.Green;
            btnRapport.ForeColor = Color.White;
        }

        private void btnRapport_MouseLeave(object sender, EventArgs e)
        {
            btnRapport.BackColor = Color.FromArgb(40,100,120);
            btnRapport.ForeColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(40, 100, 120);
            button1.ForeColor = Color.White;
        }
        #endregion
    }
}
