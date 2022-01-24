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
        string valeursPlateau = null;

        List<string> valeursCases = new List<string>()
        {
            "1","2","3","4","5","6","7","8",
            "1","2","3","4","5","6","7","8"
        };

        Label premiereSelection, secondeSelection;

        public FenetreJeu(bool estServeur, string ip = null)
        {
            InitializeComponent();
            receptioMessage.DoWork += ReceptioMessage_DoWork;
           CheckForIllegalCrossThreadCalls = false;

            if (estServeur)
            {
                serveur = new TcpListener(System.Net.IPAddress.Any, 5732);
                serveur.Start();
                socket = serveur.AcceptSocket();
                AssignerCases();

                MessageBox.Show("text complet = " + valeursPlateau + " premiere valeur de valeurplateau = " + valeursPlateau[0] + " valeur (première) case : " + label1.Text + " valeur première case : " + tableLayoutPanelPlateauJeu.Controls[0].Text + " valeur dernière case : " + tableLayoutPanelPlateauJeu.Controls[15].Text + " ---> " + tableLayoutPanelPlateauJeu.Controls[15].Name);
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
            }
        }

        private void ReceptioMessage_DoWork(object sender, DoWorkEventArgs e)
        {
            receptionDonneesInitialisation();
        }

        private void receptionDonneesInitialisation()
        {
            byte[] buffer = new byte[16];
            Label label;

            socket.Receive(buffer);
            string reception = Encoding.ASCII.GetString(buffer);
            labelTest.Text = reception;

            int test = valeursCases.Count;

            for(int i = 0; i<tableLayoutPanelPlateauJeu.Controls.Count;i++)
            {
                if (tableLayoutPanelPlateauJeu.Controls[i] is Label)
                    label = (Label)tableLayoutPanelPlateauJeu.Controls[i];
                else
                    continue;
                
                label.Text = reception[i].ToString(); 
            }


           
            
            //MessageBox.Show(reception);
        }

        private Socket socket;
        private BackgroundWorker receptioMessage = new BackgroundWorker();
        private TcpListener serveur = null;
        private TcpClient client;

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
            int test = valeursCases.Count;

            for(int i = 0; i<tableLayoutPanelPlateauJeu.Controls.Count;i++)
            {
                if (tableLayoutPanelPlateauJeu.Controls[i] is Label)
                    label = (Label)tableLayoutPanelPlateauJeu.Controls[i];
                else
                    continue;
                nombreAleatoire = aleatoire.Next(0, valeursCases.Count);
                
                valeursPlateau = valeursPlateau + valeursCases[nombreAleatoire].ToString();
                label.Text = valeursCases[nombreAleatoire];
                valeursCases.RemoveAt(nombreAleatoire); 
            }

            byte[] donneesEnvoyees = Encoding.ASCII.GetBytes(valeursPlateau);
            socket.Send(donneesEnvoyees);
            receptioMessage.RunWorkerAsync();
        }
    }
}
