using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGroupe5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Enregistrement());
            if ((EstLicenceValide()))
            {
                Application.Run(new Démarrage());
            }
            else
            {
                Application.Run(new clé_de_licence());
            }
        }
        private static bool EstLicenceValide()
        {
            try
            {
                string cle = ProjetGroupe5.Properties.Settings.Default.Cle;
                string expirationStr = ProjetGroupe5.Properties.Settings.Default.Expiration;
                if (string.IsNullOrEmpty(cle) || string.IsNullOrEmpty(expirationStr))
                {
                    return false; // Pas de clé ou pas d'expiration, licence non

                }
                DateTime expiration = DateTime.Parse(expirationStr);
                if (DateTime.Now > expiration)
                {
                    return false; // Licence expirée
                }
                return true; // Licence valide
            }
            catch (Exception)
            {
                return false; // En cas d'erreur, considérer la licence comme invalide
            }

        }
    }
    
}
