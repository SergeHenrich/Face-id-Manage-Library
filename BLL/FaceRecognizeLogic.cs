using Emgu;
using System;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FaceRecognizeLogic
    {
        public EigenObjectRecongnizer _adminRecognizer;
        public EigenObjectRecongnizer _userRecognizer;
        #region Model logic Administrateur
        public void TrainModelForAdmins(List<Image<Gray, byte>> images, List<string> labels)
        {
            if (images == null || images.Count == 0)
            {
                throw new ArgumentException("Les images d'entraînement pour les administrateurs ne peuvent pas être nulles ou vides.");
            }
            if (labels == null || labels.Count == 0)
            {
                throw new ArgumentException("Les étiquettes pour les administrateurs ne peuvent pas être nulles ou vides.");
            }
            MCvTermCriteria termCrit = new MCvTermCriteria(images.Count, 0.001);
            _adminRecognizer = new EigenObjectRecongnizer();
            _adminRecognizer.TrainModel(images.ToArray(), labels.ToArray(), 3000, ref termCrit);
        }

        public string RecognizeFaceForAdmins(Image<Gray, byte> image)
        {
            if (_adminRecognizer == null)
            {
                throw new InvalidOperationException("Le modèle des administrateurs doit être entraîné avant la reconnaissance.");
            }
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "L'image fournie ne peut pas être nulle.");
            }
            return _adminRecognizer.RecognizeFace(image);
        }
        #endregion

        #region Model logic Utilisateur
        public void TrainModelForUsers(List<Image<Gray, byte>> images, List<string> labels)
        {
            if (images == null || images.Count == 0)
            {
                throw new ArgumentException("Les images d'entraînement pour les administrateurs ne peuvent pas être nulles ou vides.");
            }
            if (labels == null || labels.Count == 0)
            {
                throw new ArgumentException("Les étiquettes pour les administrateurs ne peuvent pas être nulles ou vides.");
            }
            MCvTermCriteria termCrit = new MCvTermCriteria(images.Count, 0.001);
            _userRecognizer = new EigenObjectRecongnizer();
            _userRecognizer.TrainModel(images.ToArray(), labels.ToArray(), 3000, ref termCrit);
        }
        public string RecognizeFaceForUsers(Image<Gray, byte> image)
        {
            if (_userRecognizer == null)
            {
                throw new InvalidOperationException("Le modèle des utilisateurs doit être entraîné avant la reconnaissance.");
            }
            if (image == null)
            {
                throw new ArgumentException("L'image fournie ne peut pas être nulle.");
            }
            return _userRecognizer.RecognizeFace(image);
        }
        #endregion

    }
}
