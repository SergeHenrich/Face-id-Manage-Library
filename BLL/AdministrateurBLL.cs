using Emgu.CV;
using System;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdministrateurBLL
    {
        public int id { get; set; }
        public string CodeAdmin { get; set; }
        public string nomAdmin { get; set; }
        public string prenomAdmin { get; set; }
        public string telephoneAdmin { get; set; }
        public bool sexeAdmin { get; set; }
        public byte[] FaceIDAdmin { get; set; }
        public Image<Gray, byte> FaceImageGray { get; set; }
    }
}
