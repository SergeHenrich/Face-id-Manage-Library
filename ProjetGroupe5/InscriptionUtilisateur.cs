using Emgu;
using System;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BL;
using System.IO;
using DAL;

namespace ProjetGroupe5
{
    public partial class InscriptionUtilisateur : Form
    {
        FaceRecognizeService service = new FaceRecognizeService();
        UtilisateurDAL udal = new UtilisateurDAL();
        #region Variables
        Capture grabber; // partir de la caméra
        Image<Bgr, byte> currentFrame; //actuelle capturée
        // Bibliothèque pour les collections 
        // Bibliothèque pour l'interaction 
        // Bibliothèque pour la manipulation 
        // Bibliothèque pour la gestion des 
        // Bibliothèque pour les interfaces 
        // Capture d'image à 
        // Stocke l'image 
        Image<Gray, byte> gray, result, TrainedFace = null; // Images pour   HaarCascade face;                          // Cascade de Haar pour la détection de visages
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>(); // Liste des images d'entraînement 
        List<string> labels = new List<string>();  // Liste des étiquettes  associées aux images d'entraînement 
        int ContTrain = 0;                         // Compteur pour le  nombre d'images d'entraînement
        int t = 0;                                 // Compteur pour le nombre de visages détectés niveaux de gris, résultat et visage entraîné
        HaarCascade face = new HaarCascade("haarcascade_frontalface_default.xml");
        #endregion

        public InscriptionUtilisateur()
        {
            InitializeComponent();
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

        #region Effacer
        private void btnEffacerUtil_Click(object sender, EventArgs e)
        {
            Clearform();
        }
        #endregion

        #region Clearform
        private void Clearform()
        {
            txtMatriculeUtil.Text = string.Empty;
            txtNomUtil.Text = string.Empty;
            txtPrenomUtil.Text = string.Empty;
            txtTelUtil.Text = string.Empty;
            cmbSexeUtil.SelectedIndex = -1;
            Arrêter();
        }
        #endregion

        #region Ouvrir Caméra
        private void btnLancerRecognizUtil_Click(object sender, EventArgs e)
        {
            try
            {
                grabber = new Capture();                    // Initialise la capture vidéo
                grabber.QueryFrame();                       // Capture un frame initial


                if (grabber == null)
                {
                    MessageBox.Show("Erreur : Impossible de se connecter à la caméra.");
                    return;
                }

                Application.Idle += FrameGrabber;           // Ajoute FrameGrabber pour traitement continu
                btnDectectUtil.Visible = true;                 // Rend le bouton "Détecter" visible
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
        #endregion

        #region Détection Faciale
        private void btnDectectUtil_Click(object sender, EventArgs e)
        {
            btnCompteUtil.Visible = true;                // Rend le bouton "Créer Compte" visible

            // Redimensionne le visage détecté pour l'entraînement et  l'affiche dans imageBox2 
            TrainedFace = result.Resize(100, 100, INTER.CV_INTER_CUBIC);
            pic2.Image = TrainedFace.Bitmap;
        }

        
        #endregion

        #region Créer Compte
        private void btnCompteUtil_Click(object sender, EventArgs e)
        {
            if (cmbSexeUtil.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner le sexe de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Récupérer les valeurs des champs du formulaire
            UtilisateurBLL utilisateur = new UtilisateurBLL
            {
                matriculeUt = txtMatriculeUtil.Text,
                nomUt = txtNomUtil.Text,
                prenomUt = txtPrenomUtil.Text,
                telephoneUt = txtTelUtil.Text,
                password = txtPasswordUtil.Text,
                sexeUt = (cmbSexeUtil.SelectedItem.ToString() == "") // Récupérer la valeur sélectionnée dans le ComboBox
            };

           

            if (string.IsNullOrEmpty(utilisateur.nomUt) || string.IsNullOrEmpty(utilisateur.password))
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            utilisateur.password = Cryptography.Encrypter(utilisateur.password); // Encrypter le mot de passe

            // Conversion de l'image en tableau d'octets
            MemoryStream ms = new MemoryStream();
            Bitmap bmp = new Bitmap(100, 100);
            pic2.DrawToBitmap(bmp, new Rectangle(0, 0, 100, 100));
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            utilisateur.FaceIDutil = ms.ToArray();

            // Enregistrement des données faciales dans la base de données
            service.userDal.AddUsers(utilisateur);
            service.TrainModelForUsers(); // Entraîne le modèle pour les utilisateurs
            int id = udal.getUsersIDByNames(utilisateur.nomUt);
            SoundPlayer play1 = new SoundPlayer(Properties.Resources.son4);
            play1.Play();
            MessageBox.Show("Utilisateur " + utilisateur.nomUt + " ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult result1 = MessageBox.Show("Votre ID Utilisateur est " + id + ". Veuillez le retenir !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            // Réinitialiser tous les champs du formulaire
            Clearform();
            if(result1 == DialogResult.OK)
            {
                ConnexionUtilisateur cu = new ConnexionUtilisateur();
                cu.Show();
                this.Hide();
            }
        }

        
        #endregion

        #region RegionFrameGrabber
        void FrameGrabber(object sender, EventArgs e)
        {
            // Capture le frame actuel depuis la caméra et le redimensionne 
            currentFrame = grabber.QueryFrame().Resize(320, 240, INTER.CV_INTER_CUBIC);

            // Convertit l'image capturée en niveaux de gris 
            gray = currentFrame.Convert<Gray, Byte>();

            // Détecte les visages dans l'image en niveaux de gris 
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            // Pour chaque visage détecté, exécute l'action suivante 
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t++;  // Incrémente le compteur de visages détectés 
                      // Recadre et redimensionne le visage détecté pour créer  une image de résultat
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                // Dessine un rectangle rouge autour du visage détecté 
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
            }

            // Affiche l'image traitée dans imageBox1 
            pic1.Image = currentFrame.Bitmap;
        }
        #endregion

        #region FormLoad
        private void InscriptionUtilisateur_Load(object sender, EventArgs e)
        {
            btnDectectUtil.Visible = false;
            btnCompteUtil.Visible = false;
        }

        private void txtPasswordUtil_TextChanged(object sender, EventArgs e)
        {
            if(txtPasswordUtil.Text.Length>=1 && txtPasswordUtil.Text.Length<=2)
            {
                lbl_info.Text = " Mot de passe très faible";
            }
            else if(txtPasswordUtil.Text.Length >= 4 && txtPasswordUtil.Text.Length<=5)
            {
                lbl_info.Text = " mot de passe assez solide ";
            }
            else if(txtPasswordUtil.Text.Length==3)
            {
                lbl_info.Text = "Mot de passe faible";
            }
            else if(txtPasswordUtil.Text.Length>5)
            {
                lbl_info.Text = "Mot de passe solide";
            }
            else if(txtPasswordUtil.Text.Length==0)
            {
                lbl_info.Text = "";
            }
        }
        #endregion

        #region Retour
        private void btnRetour_Click(object sender, EventArgs e)
        {
            ConnexionUtilisateur cu = new ConnexionUtilisateur();
            cu.Show();
            this.Hide();
        }
        #endregion

        #region Arrêter Caméra 
        private void Arrêter()
        {
            if (grabber != null)
            {
                Application.Idle -= FrameGrabber;  // Arrête l'événement FrameGrabber pour le traitement continu grabber.Dispose();
                // Libère la capture  pour arrêter la caméra
                grabber = null; //pour éviter toute réutilisation accidentelle
            }
        }
        #endregion
    }
}
