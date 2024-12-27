using Emgu.CV;
using System;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using BL;

namespace ProjetGroupe5
{
    public partial class ConnexionUtilisateur : Form
    {

        FaceRecognizeService service = new FaceRecognizeService();
        UtilisateurBLL ubll = new UtilisateurBLL();
        UtilisateurDAL udal;

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

        public ConnexionUtilisateur()
        {
            InitializeComponent();
            try
            {
               
                face = new HaarCascade("haarcascade_frontalface_default.xml");
                InitializeDatabase();
                udal = new UtilisateurDAL();
                service.TrainModelForUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'initialisation : " + ex.Message);
            }
            btnConnexionUtil.Visible = false;
        }

        #region Se connecter
        private void btnConnexionUtil_Click(object sender, EventArgs e)
        {
            SoundPlayer play1 = new SoundPlayer(Properties.Resources.son);
            // Récupérer les valeurs des champs du formulaire
            ubll.nomUt = txtNomUtilConnex.Text;
            ubll.password = txtPasswordUtilConnex.Text;

            if (string.IsNullOrEmpty(ubll.nomUt) || string.IsNullOrEmpty(ubll.password))
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Vérifier si l'utilisateur existe dans la base de données
                bool usersExists = udal.VerifyUsersInDatabase(ubll.nomUt, ubll.password); 

                if (usersExists)
                {
                    play1.Play();
                    MessageBox.Show("Connexion réussie", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Emprunt sm = new Emprunt();
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
            InscriptionUtilisateur util = new InscriptionUtilisateur();
            util.Show();
            this.Hide();
        }
        #endregion

        #region Retour choix
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
                // Capture une image dans la caméra
                currentFrame = grabber.QueryFrame()?.Resize(320, 240, INTER.CV_INTER_CUBIC);
                if (currentFrame == null)
                {
                    MessageBox.Show("Erreur : impossible de capturer un frame depuis la caméra");
                    return;
                }
                // Redimensionne la taille de l'image à partir du cadre formé. 
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
                        name = service.RecognizeFaceForUsers(result);

                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    }
                    NamePersons[t - 1] = name;
                    NamePersons.Add("");
                }
                t = 0;
                names = string.Join(" ", NamePersons.ToArray());
                cameraBox2.Image = currentFrame;
                txtNomUtilConnex.Text = names;

                // Vérification des noms reconnus et mise à jour du txtCode.Text
                if (!string.IsNullOrEmpty(names))
                {
                    string usersPassword = udal.GetCodeForUsersname(names);
                    if (!string.IsNullOrEmpty(usersPassword))
                    {
                        txtPasswordUtilConnex.Text = usersPassword;
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

        #region Effacer
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Arrêter();
        }

        
        #endregion

        #region Clearform
        private void Clearform()
        {
            txtNomUtilConnex.Text = string.Empty;
            txtPasswordUtilConnex.Text = string.Empty;
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

        #region InitializeDataBase
        private void InitializeDatabase()
        {
            try
            {
                
                var trainingData = service.userDal.GetAllUsers();
                if (trainingData == null || trainingData.Count == 0)
                {
                    throw new Exception("Aucune donnée de formation trouvée.");
                }
                foreach (var data in trainingData)
                {
                    trainingImages.Add(data.FaceImageGray); labels.Add(data.nomUt);
                }
                contrain = trainingData.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pas d'image formée: " + ex.Message);
            }
        }
        #endregion

        #region Reconnaissance
        private void btnLancerRecognizUtil_Click(object sender, EventArgs e)
        {
            try
            {
                grabber = new Capture();
                if (grabber == null)
                {
                    MessageBox.Show("Erreur : impossible de se connecter à la camera.");
                    return;
                }
                btnConnexionUtil.Visible = true;
                grabber.QueryFrame();
                Application.Idle += new EventHandler(FrameGrabber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'initialisation de la camera : " + ex.Message);
            }
        }
        #endregion

    }
}
