using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGroupe5
{
    public partial class OptionDémarrage : Form
    {
        public OptionDémarrage()
        {
            SoundPlayer play = new SoundPlayer(Properties.Resources.son2);
            play.Play();
            InitializeComponent();
        }

        private void btnAdministrateur_Click(object sender, EventArgs e)
        {
            ConnexionAdmin ca = new ConnexionAdmin();
            ca.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnexionUtilisateur cu = new ConnexionUtilisateur();
            cu.Show();
            this.Hide();
        }

        private void lblQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipeDeveloppeur ed = new EquipeDeveloppeur();
            ed.Show();
            this.Hide();
        }
    }
}
