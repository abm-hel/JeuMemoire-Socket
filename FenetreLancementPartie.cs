using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMemoire_Socket
{
    public partial class FenetreLancementPartie : Form
    {
        public FenetreLancementPartie()
        {
            InitializeComponent();
        }

        private void buttonSeConnecter_Click(object sender, EventArgs e)
        {
            FenetreJeu nouvellePartie = new FenetreJeu(false, textBoxAdresseIP.Text);
            Visible = false;
            if (!nouvellePartie.IsDisposed)
                nouvellePartie.ShowDialog();
            Visible = true;
        }

        private void buttonCommencerPartie_Click(object sender, EventArgs e)
        {
            FenetreJeu nouvellePartie = new FenetreJeu(true);
            Visible = false;
            if (!nouvellePartie.IsDisposed)
                nouvellePartie.ShowDialog();
            Visible = true;
        }
    }
}
