using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGroupe5
{
    public partial class EquipeDeveloppeur : Form
    {
        public EquipeDeveloppeur()
        {
            InitializeComponent();
            message();
        }
        #region Retour
        private void button1_Click(object sender, EventArgs e)
        {
            OptionDémarrage od = new OptionDémarrage();
            od.Show();
            this.Hide();
        }
        #endregion
        
        private void message()
        {
            string Presentation = "Nous sommes un groupe de développeurs passionnés par l'intelligence artificielle et le développement C#. Notre application de reconnaissance faciale est le fruit d'un travail rigoureux et collaboratif, alliant expertise technique et créativité.Nous avons utilisé les dernières technologies C# pour créer une solution robuste, précise et facile à utiliser. Notre approche est axée sur la performance, la fiabilité et la sécurité des données.Nous sommes fiers de la qualitéde notre application et de son potentiel à révolutionner la façon dont la reconnaissance faciale est utilisée.";
            lblDescriptionEquipe.Text = Presentation;
        }
    }
}
