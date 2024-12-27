using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmpruntBLL
    {
        public int id { get; set; }
        public int UsersID { get; set; }
        public int BookID { get; set; }
        public DateTime dateEmprunt { get; set; }
        public DateTime? dateRetour { get; set; }
    }
}
