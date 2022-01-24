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
    public partial class FenetreJeu : Form
    {
        Random aleatoire = new Random();
        List<string> valeursCases = new List<string>()
        {
            "1","2","3","4","5","6","7","8",
            "1","2","3","4","5","6","7","8"
        };

        Label premiereSelection, secondeSelection;

        public FenetreJeu()
        {
            InitializeComponent();
            AssignerCases();
        }

        private void selectionCase(object sender, EventArgs e)
        {
            if (premiereSelection != null && secondeSelection != null)
                return;

            Label caseSelectionnee = sender as Label;

            if (caseSelectionnee == null)
                return;

            if (caseSelectionnee.ForeColor == Color.White)
                return;

            if(premiereSelection == null)
            {
                premiereSelection = caseSelectionnee;
                premiereSelection.ForeColor = Color.White;
                return;
            }

            secondeSelection = caseSelectionnee;
            secondeSelection.ForeColor = Color.White;

            VerificationGagnant();

            if (premiereSelection.Text == secondeSelection.Text)
            {
                premiereSelection = null;
                secondeSelection = null;
            }

            else
                timerJeu.Start();
        }

        private void timerJeu_Tick(object sender, EventArgs e)
        {
            timerJeu.Stop();

            premiereSelection.ForeColor = Color.Black;
            secondeSelection.ForeColor = Color.Black;

            premiereSelection = null;
            secondeSelection = null;
        }

        private void VerificationGagnant()
        {
            Label label;

            for (int i = 0 ; i < tableLayoutPanelPlateauJeu.Controls.Count ; i++)
            {
                label = tableLayoutPanelPlateauJeu.Controls[i] as Label;

                if (label != null && label.ForeColor == Color.Black)
                    return;
            }

            MessageBox.Show("Partie terminée");
            Close();
        }

        private void AssignerCases()
        {
            Label label;
            int nombreAleatoire;

            for(int i = 0; i<tableLayoutPanelPlateauJeu.Controls.Count;i++)
            {
                if (tableLayoutPanelPlateauJeu.Controls[i] is Label)
                    label = (Label)tableLayoutPanelPlateauJeu.Controls[i];
                else
                    continue;

                nombreAleatoire = aleatoire.Next(0, valeursCases.Count);
                label.Text = valeursCases[nombreAleatoire];

                valeursCases.RemoveAt(nombreAleatoire);

            }

        }
    }
}
