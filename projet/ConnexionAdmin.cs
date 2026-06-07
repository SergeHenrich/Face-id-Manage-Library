using Emgu;
using Emgu.CV;
using System;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using BL;

namespace ProjetGroupe5
{
    
    public partial class ConnexionAdmin : Form
    {
        FaceRecognizeService service = new FaceRecognizeService();
        AdministrateurDAL adal;
        AdministrateurBLL adll = new AdministrateurBLL();
         AdministrateurDAL ba = new AdministrateurDAL();
        AdministrateurBLL da = new AdministrateurBLL();

        #region Region Variables
        Image<Bgr, byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        List<string> NamePersons = new List<string>();
        string name, names = null;
        int t, contrain, NumLabels;
        #endregion

        public ConnexionAdmin()
        {
            InitializeComponent();
            try
            {                
                face = new HaarCascade("haarcascade_frontalface_default.xml");
                InitializeDatabase();
                adal = new AdministrateurDAL();
                service.TrainModelForAdmins();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'initialisation : " + ex.Message);
            }
            btnConnexionAd.Visible = false;            
        }

        #region Effacer
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Arrêter();
        }
        #endregion

        #region Se connecte
        private void btnConnexionAd_Click(object sender, EventArgs e)
        {
            SoundPlayer play1 = new SoundPlayer(Properties.Resources.son);
            // Récupérer les valeurs des champs du formulaire
            adll.nomAdmin = txtNomAdConnex.Text;
            adll.CodeAdmin = txtCodeAdConnex.Text;

            if (string.IsNullOrEmpty(adll.nomAdmin) || string.IsNullOrEmpty(adll.CodeAdmin))
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Vérifier si l'utilisateur existe dans la base de données
                bool adminExists = adal.VerifyAdminInDatabase(adll.nomAdmin, adll.CodeAdmin);

                if (adminExists)
                {
                    play1.Play();
                    MessageBox.Show("Connexion réussie", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Gestionnaires sm = new Gestionnaires();
                    sm.Show();
                }
                else
                {
                    MessageBox.Show("Identifiants incorrects! Veuillez réessayer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEffacer_Click(sender, e);
                }
            }
        }
        #endregion

        #region Créer Compte
        private void btnCréerCompte_Click(object sender, EventArgs e)
        {
            InscriptionAdmin admin = new InscriptionAdmin();
            admin.Show();
            this.Hide();
        }
        #endregion

        #region Revenir Choix
        private void lblQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous rentrer au choix de connexion ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OptionDémarrage od = new OptionDémarrage();
                od.Show();
                this.Hide();
            }
        }
        #endregion

        #region Clearform
        private void Clearform()
        {
            txtCodeAdConnex.Text = "";
            txtNomAdConnex.Text = "";
            Arrêter();
        }

        private void pnlTitreCU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConnexionAdmin_Load(object sender, EventArgs e)
        {

        }

        private void ChargerInformationsLicence()
        {
            // Charger les informations de licence depuis les paramètres de

            clé_de_licence activ = new clé_de_licence();
            activ.txt_cle_produit.Text = Properties.Settings.Default.Cle;
            activ.txt_date_cration.Text = Properties.Settings.Default.Creation;
            activ.txt_jrs_restant.Text = Properties.Settings.Default.jours_Restant;
            activ.txt_date_expiration.Text = Properties.Settings.Default.Expiration;
            // Valider la clé de licence
            ValiderLicence();
        }
        #endregion

        #region Valider Licence
        private void ValiderLicence()
        {
            try
            {
                // Calculer les jours restants à partir de la date d'expiration
                DateTime expirationDate =
                DateTime.Parse(Properties.Settings.Default.Expiration);
                double joursRestants = (expirationDate - DateTime.Now).TotalDays;
                // Si la licence a expiré, afficher un message et rediriger vers

                if (joursRestants < 0)
                {
                    OuvrirFormulaireActivation();
                }
                else
                {
                    // Licence valide, permettre l'accès à la connexion
                    txtNomAdConnex.Visible = true;
                    txtCodeAdConnex.Visible = true;
                }
            }
            catch (Exception)
            {
                // En cas d'erreur de validation de la licence, demander l'activation
                AfficherMessageErreur("Erreur de licence. Veuillez contacter le développeur.");
                OuvrirFormulaireActivation();
            }
        }
        #endregion

        #region OuvrirFormulaireActivation
        private void OuvrirFormulaireActivation()

        {
            clé_de_licence activateurCle = new clé_de_licence();
            this.Hide(); // Cacher le formulaire de connexion
            activateurCle.ShowDialog(); // Ouvrir le formulaire d'activation
            this.Show(); // Réafficher le formulaire de connexion après l'activation
        }
        #endregion

        #region MessageErreur
        private void AfficherMessageErreur(string message)
        {
            MessageBox.Show(message, "Erreur de Licence", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            txtNomAdConnex.Visible = false;
            txtCodeAdConnex.Visible = false;
        }
        #endregion

        #region Boutton Voir Licence
        private void btnVoirLIcence_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime expirationDate =
                DateTime.Parse(Properties.Settings.Default.Expiration);
                double joursRestants = (expirationDate - DateTime.Now).TotalDays;
                string message;
                if (joursRestants < 0)
                {
                    message = "L'application n'est pas activée ou la licence a expiré.";
                }
                else
                {
                    string cleLicence = Properties.Settings.Default.Cle;
                    message = $"L'application est activée.\nClé de licence :{ cleLicence}\nDate d'expiration : {expirationDate.ToShortDateString()}";
                }

                MessageBox.Show(message, "État de la Licence", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de la vérification de la licence.",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #region Reconnaissance
        private async void btnLancerRecognizCAd_Click(object sender, EventArgs e)
        {
            try
            {
                grabber = new Capture(); if (grabber == null)
                {
                    MessageBox.Show("Erreur : impossible de se connecter à la camera.");
                    return;
                }
                for (int i = 0; i < 10; i++)
                {
                    grabber.QueryFrame(); // Capturer plusieurs frames pour stabiliser la caméra 
                    await Task.Delay(100); // Petit délai entre les captures 
                }
                btnConnexionAd.Visible = true;
                Application.Idle += new EventHandler(FrameGrabber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'initialisation de la camera : " + ex.Message);
            }
         }
        #endregion

        #region InitializeDataBase
        private void InitializeDatabase()
        {
            try
            {
                int count = 0;
                var trainingData = service.adminDal.GetAllAdmins();
                if (trainingData == null || trainingData.Count == 0)
                {
                    throw new Exception("Aucune donnée de formation trouvée.");
                }
                foreach (var data in trainingData)
                {
                    trainingImages.Add(data.FaceImageGray); labels.Add(data.nomAdmin);
                }
                contrain = trainingData.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pas d'image formée: " + ex.Message);
            }
        }
        #endregion

        #region Méthode des événements
        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
                if (trainingImages.Count == 0 || labels.Count == 0)
                {
                    MessageBox.Show("Aucune image d'entraînement trouvée.");
                    return;
                }

                NamePersons.Add("");
                
                //Capture une image dans la caméra
                currentFrame = grabber.QueryFrame()?.Resize(340, 260, INTER.CV_INTER_CUBIC);
                if (currentFrame == null)
                {
                    MessageBox.Show("Erreur : impossible de capturer un frame depuis la caméra");
                    return;
                }
                //redimmensionne la taille de l'image à partir du cadre formé. 
                gray = currentFrame.Convert<Gray, Byte>();
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                foreach (MCvAvgComp f in facesDetected[0])
                {
                    t++;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

                    if (trainingImages.Count > 0)
                    {
                        // Utiliser le recognizer déjà initialisé dans FaceRecognizeService
                        name = service.RecognizeFaceForAdmins(result);

                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    }
                    NamePersons[t - 1] = name;
                    NamePersons.Add("");
                    
                }
                t = 0;
                names = string.Join(" ", NamePersons.ToArray());
                imageBox1.Image = currentFrame;
                txtNomAdConnex.Text = names;

                if (!string.IsNullOrEmpty(names))
                {
                    if (adal == null)
                    {
                        MessageBox.Show("Erreur : adal n'est pas initialisé");
                        return;
                    }

                    string adminCode = adal.GetCodeForAdminname(names);
                    if (!string.IsNullOrEmpty(adminCode))
                    {
                        txtCodeAdConnex.Text = adminCode;
                    }
                }

                NamePersons.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du traitement de l'image : " + ex.Message);
            }
        }

        #endregion

    }
}
