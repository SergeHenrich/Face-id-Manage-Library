using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;
using System.Security.Cryptography;

namespace ProjetGroupe5
{
    public partial class clé_de_licence : Form
    {
        private const string hach = "Générateur clé de licence GROUPE 5";
        public clé_de_licence()
        {
            InitializeComponent();

            txt_id.Text = ComputerInfo.GetComputerId();
        }

        private void clé_de_licence_Load(object sender, EventArgs e)
        {
            txt_cle_produit.Text = Properties.Settings.Default.Cle;
            txt_date_cration.Text = Properties.Settings.Default.Creation;
            txt_jours.Text = Properties.Settings.Default.jours_Restant;
            txt_date_expiration.Text = Properties.Settings.Default.Expiration;
        }

        private void btn_activer_Click(object sender, EventArgs e)
        {
            if (!rdbc.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Veuillez selectionner une option (C OU P).", "erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            try
            {
                byte[] data = rdbc.Checked
                    ? Encoding.UTF8.GetBytes(txt_id.Text) : Encoding.UTF32.GetBytes(txt_id.Text);
                byte[] hashedKey = GetHashedKey(hach);
                byte[] encryptedData = EncryptData(data, hashedKey);
                SKGL.Validate validate = new SKGL.Validate { secretPhase = Convert.ToBase64String(encryptedData) };
                validate.Key = txt_cle_produit.Text;
                if (validate.IsValid)
                {
                    SaveActivationDetails(validate.DaysLeft.ToString());
                    MessageBox.Show("Clé de licence activée avec succès.",
                    "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Démarrage().Show();
                }
                else
                {
                    MessageBox.Show("Clé de licence invalide ou expirée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'activation : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetHashedKey(string hachage)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                // Calcul du haché MD5 et retour du tableau d'octets résultant
                return md5.ComputeHash(Encoding.UTF8.GetBytes(hachage));
            }
        }
        private byte[] EncryptData(byte[] data, byte[] key)
        {
            using (TripleDESCryptoServiceProvider tripleDES = new
            TripleDESCryptoServiceProvider
            {
                Key = key, // Clé utilisée pour le chiffrement
                Mode = CipherMode.ECB, // Mode de chiffrement (ECB dans ce cas)
                Padding = PaddingMode.PKCS7 // Mode de remplissage pour le
            })
            {
                ICryptoTransform transform = tripleDES.CreateEncryptor(); // Création

                // Retourne le tableau d'octets chiffrés
                return transform.TransformFinalBlock(data, 0, data.Length);
            }
        }
        private void SaveActivationDetails(string remainingDays)
        {
            Properties.Settings.Default.Cle = txt_cle_produit.Text;
            Properties.Settings.Default.Creation = DateTime.Now.ToString("yyyy-MM-dd");
            Properties.Settings.Default.Expiration =
DateTime.Now.AddDays(int.Parse(remainingDays)).ToString("yyyy-MM-dd");
            Properties.Settings.Default.jours_Restant = remainingDays;
            Properties.Settings.Default.Save();
        }
    }
}
