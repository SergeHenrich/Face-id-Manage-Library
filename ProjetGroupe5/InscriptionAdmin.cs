using BL;
using DAL;
using BLL;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ProjetGroupe5
{   
    public partial class InscriptionAdmin : Form
    {
        FaceRecognizeService service = new FaceRecognizeService();

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

        public InscriptionAdmin()
        {
            InitializeComponent();
        }
        #region ClearForm
        private void Clearform()
        {
            txtCodeAd.Text = string.Empty;
            txtNomAd.Text = string.Empty;
            txtPrenomAd.Text = string.Empty;
            txtTelAd.Text = string.Empty;
            cmbSexeAd.SelectedIndex = -1;
            Arrêter();
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

        #region FormLoad
        private void InscriptionAdmin_Load(object sender, EventArgs e)
        {
            btnDetectAd.Visible = false;
            btnCompteAd.Visible = false;
        }
        
        #endregion

        #region Effacer
        private void btnEffacerAd_Click(object sender, EventArgs e)
        {
            Clearform();
            
        }

        
        #endregion

        #region Détection Faciale
        private void btnDetectAd_Click(object sender, EventArgs e)
        {
                                  
            btnCompteAd.Visible = true;                // Rend le bouton "Créer Compte" visible

            // Redimensionne le visage détecté pour l'entraînement et  l'affiche dans imageBox2 
            TrainedFace = result.Resize(100, 100, INTER.CV_INTER_CUBIC);
            pic2.Image = TrainedFace.Bitmap;
        }
        #endregion

        #region Créer Compte
        private void btnCompteAd_Click(object sender, EventArgs e)
        {
            if (cmbSexeAd.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner le sexe de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Récupérer les valeurs des champs du formulaire
            AdministrateurBLL admin = new AdministrateurBLL
            {
                CodeAdmin = txtCodeAd.Text,
                nomAdmin = txtNomAd.Text,
                prenomAdmin = txtPrenomAd.Text,
                telephoneAdmin = txtTelAd.Text,
                sexeAdmin = (cmbSexeAd.SelectedItem.ToString() == "") // Récupérer la valeur sélectionnée dans le ComboBox 
            };

            if (string.IsNullOrEmpty(admin.nomAdmin) || string.IsNullOrEmpty(admin.CodeAdmin))
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            admin.CodeAdmin = Cryptography.Encrypter(admin.CodeAdmin);
            // Conversion de l'image en tableau d'octets 
            MemoryStream ms = new MemoryStream(); Bitmap bmp = new Bitmap(100, 100);
            pic2.DrawToBitmap(bmp, new Rectangle(0, 0, 100, 100));
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            admin.FaceIDAdmin = ms.ToArray();
            // Enregistrement des données faciales dans la base de données 
            service.adminDal.Admininsert(admin);
            service.TrainModelForAdmins();
            SoundPlayer play1 = new SoundPlayer(Properties.Resources.son4);
            play1.Play();
            // Entraîne le modèle pour les utilisateurs 
            DialogResult result= MessageBox.Show("Administrateur " + admin.nomAdmin + " ajouté avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            // Réinitialiser tous les champs du formulaire 
            Clearform();
            if(result == DialogResult.OK)
            {
                ConnexionAdmin ca = new ConnexionAdmin();
                ca.Show();
                this.Hide();
            }
        }

       
        #endregion

        #region Ouvrir Caméra
        private void btnLancerRecognizAd_Click(object sender, EventArgs e)
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
                btnDetectAd.Visible = true;                 // Rend le bouton "Détecter" visible
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
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

        private void txtCodeAd_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeAd.Text.Length >= 1 && txtCodeAd.Text.Length <= 2)
            {
                lbl_info.Text = " code très faible";
            }
            else if (txtCodeAd.Text.Length >= 4 && txtCodeAd.Text.Length <= 5)
            {
                lbl_info.Text = " code  assez solide ";
            }
            else if (txtCodeAd.Text.Length == 3)
            {
                lbl_info.Text = "code faible";
            }
            else if (txtCodeAd.Text.Length > 5)
            {
                lbl_info.Text = "code solide";
            }
            else 
            {
                lbl_info.Text = "";
            }
        }


        #endregion

        #region Retour
        private void btnRetour_Click(object sender, EventArgs e)
        {
            ConnexionAdmin ca = new ConnexionAdmin();
            ca.Show();
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
