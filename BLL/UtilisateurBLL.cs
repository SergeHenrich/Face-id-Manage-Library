using Emgu.CV;
using System;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UtilisateurBLL
    {
        public int id { get; set; }
        public string matriculeUt { get; set; }
        public string nomUt { get; set; }
        public string prenomUt { get; set; }
        public string telephoneUt { get; set; }
        public string password { get; set; }
        public bool sexeUt { get; set; }
        public byte[] FaceIDutil { get; set; }
        public Image<Gray, byte> FaceImageGray { get; set; }
    }
}
