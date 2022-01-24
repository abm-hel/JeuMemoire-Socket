using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace JeuMemoire_Socket
{
    public partial class FenetreJeu : Form
    {
        Random aleatoire = new Random();
        int score = 0;
        List<string> valeursCases = new List<string>()
        {
            "1","2","3","4","5","6","7","8",
            "1","2","3","4","5","6","7","8"
        };

        Label premiereSelection, secondeSelection;

        public FenetreJeu(bool estServeur, string ip = null)
        {
            InitializeComponent();
            //receptioMessage.DoWork += ReceptioMessage_DoWork;
            AssignerCases();
           /* CheckForIllegalCrossThreadCalls = false;

            if (estServeur)
            {
                serveur = new TcpListener(System.Net.IPAddress.Any, 5732);
                serveur.Start();
                socket = serveur.AcceptSocket();
            } 

            else
            {
                try
                {
                    client = new TcpClient(ip, 5732);
                    socket = client.Client;
                    receptioMessage.RunWorkerAsync();
                }

                catch(Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                    Close();
                }
            }*/
        }

        private void ReceptioMessage_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

       /*private Socket socket;
        private BackgroundWorker receptioMessage = new BackgroundWorker();
        private TcpListener serveur = null;
        private TcpClient client;*/

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
                score++;
                premiereSelection = null;
                secondeSelection = null;
                //envoie valeur
            }

            else
                //envoie valeur qui ne va pas agir sur le plateau
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

            score++;
            MessageBox.Show("Partie terminée, score : "+score +" point(s)");
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
