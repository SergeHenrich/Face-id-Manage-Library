using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGroupe5
{
    public partial class Démarrage : Form
    {
        public Démarrage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnl2.Width += 6;
            if (pnl2.Width >= 575)
            {
                timer1.Stop();
                OptionDémarrage OD = new OptionDémarrage();
                OD.Show();
                this.Hide();
                
            }
        }

        private void Démarrage_Load(object sender, EventArgs e)
        {
            SoundPlayer PLAYER = new SoundPlayer(Properties.Resources.son3);
            PLAYER.Play();
        }
    }
}
