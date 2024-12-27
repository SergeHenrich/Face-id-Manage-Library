using DAL;
using BLL;
using Emgu;
using System;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL
{
    public class FaceRecognizeService
    {
        public AdministrateurDAL adminDal = new AdministrateurDAL();
        public UtilisateurDAL userDal = new UtilisateurDAL();
        public FaceRecognizeLogic logic = new FaceRecognizeLogic();

        #region Model Service Administrateur
        public void TrainModelForAdmins()
        {
            var adminData = adminDal.GetAllAdmins();
            if (adminData == null || adminData.Count == 0)
            {
                throw new InvalidOperationException("Aucune donnée d'administrateur trouvée pour l'entraînement.");
            }
            List<Image<Gray, byte>> images = new List<Image<Gray, byte>>();
            List<string> labels = new List<string>();
            foreach (var admin in adminData)
            { // Utilisation directe de FaceImageGray 
                if (admin.FaceImageGray != null)
                {
                    images.Add(admin.FaceImageGray);
                    labels.Add(admin.nomAdmin);
                }
            }
            logic.TrainModelForAdmins(images, labels);
        }


        public string RecognizeFaceForAdmins(Image<Gray, byte> image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "L'image fournie ne peut pas être nulle.");
            }
            return logic.RecognizeFaceForAdmins(image);
        }
        #endregion


        #region Model Service Utilisateur
        public void TrainModelForUsers()
        {
            var usersData = userDal.GetAllUsers();
            List<Image<Gray, byte>> images = new List<Image<Gray, byte>>();
            List<string> labels = new List<string>();

            foreach (var users in usersData)
            {
                // Utilisation directe de FaceImageGray
                images.Add(users.FaceImageGray);
                labels.Add(users.nomUt);
            }
            logic.TrainModelForUsers(images, labels);
        }

        public string RecognizeFaceForUsers(Image<Gray, byte> image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "L'image fournie ne peut pas être nulle.");
            }
            return logic.RecognizeFaceForUsers(image);
        }
        #endregion


    }
}
