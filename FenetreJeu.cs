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
        int scoreAdversaire = 0;

        string valeursPlateau = null;
        // tram = "0000000000000000x";

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
            //receptionSelectionCases.DoWork +=receptionSelectionCases_DoWork;

            CheckForIllegalCrossThreadCalls = false;

            if (estServeur)
            {
                for (int i = 0; i < tableLayoutPanelPlateauJeu.Controls.Count; i++)
                {
                    tableLayoutPanelPlateauJeu.Controls[i].Enabled = false;
                    labelTest.Text = "C'est le tour de votre adversaire";
                }
                serveur = new TcpListener(System.Net.IPAddress.Any, 5732);
                serveur.Start();
                socket = serveur.AcceptSocket();
                AssignerCases();
                

                //MessageBox.Show("text complet = " + valeursPlateau + " premiere valeur de valeurplateau = " + valeursPlateau[0] + " valeur (première) case : " + label1.Text + " valeur première case : " + tableLayoutPanelPlateauJeu.Controls[0].Text + " valeur dernière case : " + tableLayoutPanelPlateauJeu.Controls[15].Text + " ---> " + tableLayoutPanelPlateauJeu.Controls[15].Name);
            } 

            else
            {
                try
                {
                    client = new TcpClient(ip, 5732);
                    socket = client.Client;
                    receptioMessage.RunWorkerAsync();
                    //receptionSelectionCases.RunWorkerAsync();
                }

                catch(Exception exeption)
                {
                    MessageBox.Show(exeption.Message);
                    Close();
                }
            }
        }

        /*private void receptionSelectionCases_DoWork(object sender, DoWorkEventArgs e)
        {
            ReceptionSelection();
        }*/

        private void ReceptioMessage_DoWork(object sender, DoWorkEventArgs e)
        {

            //receptionDonneesInitialisation();
            byte[] buffer = new byte[18];
            socket.Receive(buffer);
            string receptiontest = Encoding.ASCII.GetString(buffer);
            if (receptiontest[16] == 't')
            {
                //MessageBox.Show(score.ToString() + "  -  " + scoreAdversaire.ToString());
                receptionDonneesInitialisation(receptiontest);
            }
            else if(receptiontest[16]=='w')
            {
               // MessageBox.Show(score.ToString() + "  -  " + scoreAdversaire.ToString());
                //score++;
                labelTest.Text = "C'est votre tour";
                if(scoreAdversaire + score == 8)
                {
                    if(score>scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, Vous avez gagné - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }

                    if (score < scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, Vous avez perdu - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }

                     if (score == scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, égalité - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }
                }

                for (int i = 0; i < tableLayoutPanelPlateauJeu.Controls.Count; i++)
                {
                   tableLayoutPanelPlateauJeu.Controls[i].Enabled = true; 
                }
            }

            else if(receptiontest[16] == 'x')
            {
                
                scoreAdversaire++;
                labelScore.Text = score.ToString();
                labelScoreAdversaire.Text = scoreAdversaire.ToString();
                //MessageBox.Show(score.ToString() + "  -  " + scoreAdversaire.ToString());
                //VerificationGagnant();
                for (int i = 0; i < tableLayoutPanelPlateauJeu.Controls.Count; i++)
                {
                    
                    if (tableLayoutPanelPlateauJeu.Controls[i].Text == Convert.ToString(receptiontest[17]))
                    {
                        tableLayoutPanelPlateauJeu.Controls[i].ForeColor = Color.White;
                    }
                }
               
                labelTest.Text = "C'est votre tour";
                if (scoreAdversaire + score == 8)
                {
                    if (score > scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, Vous avez gagné - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }

                    if (score < scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, Vous avez perdu - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }

                    if (score == scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, égalité - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }
                }

                for (int i = 0; i < tableLayoutPanelPlateauJeu.Controls.Count; i++)
                {
                    tableLayoutPanelPlateauJeu.Controls[i].Enabled = true;
                }
            }
            else if (receptiontest[16] == 'a')
            {
                if (score > scoreAdversaire)
                {
                    MessageBox.Show("Partie terminée, Vous avez gagné - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                    Close();
                }

                if (score < scoreAdversaire)
                {
                    MessageBox.Show("Partie terminée, Vous avez perdu - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                    Close();
                }

                if (score == scoreAdversaire)
                {
                    MessageBox.Show("Partie terminée, égalité - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                    Close();
                }
            }

           
            //MessageBox.Show(score.ToString() + "  -  " + scoreAdversaire.ToString());
            // MessageBox.Show(buffer.ToString());
        }

        private void receptionDonneesInitialisation(string reception)
        {
            labelTest.Text = "C'est votre tour";
            //byte[] buffer = new byte[17];
            Label label;

            //socket.Receive(buffer);
            //string reception = Encoding.ASCII.GetString(buffer);
            

            int test = valeursCases.Count;

            for(int i = 0; i<tableLayoutPanelPlateauJeu.Controls.Count;i++)
            {
                if (tableLayoutPanelPlateauJeu.Controls[i] is Label)
                    label = (Label)tableLayoutPanelPlateauJeu.Controls[i];
                else
                    continue;
                
                label.Text = reception[i].ToString(); 
            }
           
        }

        private Socket socket;

        private BackgroundWorker receptioMessage = new BackgroundWorker();
        private BackgroundWorker receptionSelectionCases = new BackgroundWorker();

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

            string valeurTest = secondeSelection.Text;

            //VerificationGagnant();

            if (premiereSelection.Text == secondeSelection.Text)
            {
                score++;
                labelScore.Text = score.ToString();
                labelScoreAdversaire.Text = scoreAdversaire.ToString();
                if (scoreAdversaire + score == 8)
                {
                    if (score > scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, Vous avez gagné - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }

                    if (score < scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, Vous avez perdu - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }

                    if (score == scoreAdversaire)
                    {
                        MessageBox.Show("Partie terminée, égalité - votre score : " + score + " point(s) - + le score de votre adreversaire : " + scoreAdversaire + " point(s)");
                        Close();
                    }
                }
                //tram = "0000000000000000x" + valeurTest;
                premiereSelection = null;
                secondeSelection = null;
                //envoie valeur
                /*byte[] donneesEnvoyees = Encoding.ASCII.GetBytes(valeursPlateau);
                socket.Send(donneesEnvoyees);
                receptioMessage.RunWorkerAsync();
                byte[] valeurCasesEgaux = premiereSelection.Text;
                
                byte[] envoi = Encoding.ASCII.GetBytes(caseSelectionnee.Text);
                socket.Send(envoi);
               
                receptionSelectionCases.RunWorkerAsync();
                tableLayoutPanelPlateauJeu.Enabled = false;*/

                //tableLayoutPanelPlateauJeu.Enabled = false;
                for(int i = 0; i < tableLayoutPanelPlateauJeu.Controls.Count; i++)
                {
                    if(tableLayoutPanelPlateauJeu.Controls[i].ForeColor == Color.Black)
                    {
                        tableLayoutPanelPlateauJeu.Controls[i].Enabled = false;
                    }
                }
                
                byte[] donneesEnvoyees = Encoding.ASCII.GetBytes("0000000000000000x"+valeurTest);
                socket.Send(donneesEnvoyees);
                receptioMessage.RunWorkerAsync();
            }

            else
            {
                timerJeu.Start();
                /*byte[] envoi = Encoding.ASCII.GetBytes("f");
                socket.Send(envoi);
                receptionSelectionCases.RunWorkerAsync();*/  
            }

            labelTest.Text = "C'est le tour de votre adversaire";

        }

       

        private void timerJeu_Tick(object sender, EventArgs e)
        {
            timerJeu.Stop();

            premiereSelection.ForeColor = Color.Black;
            secondeSelection.ForeColor = Color.Black;

            premiereSelection = null;
            secondeSelection = null;

            for (int i = 0; i < tableLayoutPanelPlateauJeu.Controls.Count; i++)
            {
                if (tableLayoutPanelPlateauJeu.Controls[i].ForeColor == Color.Black)
                {
                    tableLayoutPanelPlateauJeu.Controls[i].Enabled = false;
                }
            }
            
            byte[] donneesEnvoyees = Encoding.ASCII.GetBytes("0000000000000000w");
            socket.Send(donneesEnvoyees);
            receptioMessage.RunWorkerAsync();
            //tableLayoutPanelPlateauJeu.Enabled = false;
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
            valeursPlateau += "t";
            byte[] donneesEnvoyees = Encoding.ASCII.GetBytes(valeursPlateau);
            socket.Send(donneesEnvoyees);
            receptioMessage.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*byte[] donneesEnvoyees = Encoding.ASCII.GetBytes("test");
            socket.Send(donneesEnvoyees);
            //receptioMessage.RunWorkerAsync();*/

            byte[] num = { 2 };
            socket.Send(num);
            
            receptioMessage.RunWorkerAsync();
        }

        private void FenetreJeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            receptioMessage.WorkerSupportsCancellation = true;
            receptioMessage.CancelAsync();
            if (serveur != null)
                serveur.Stop();
        }

        private void ReceptionSelection()
        {
            byte[] buffer = new byte[3];
            socket.Receive(buffer);
            string reception = Encoding.ASCII.GetString(buffer);
            tableLayoutPanelPlateauJeu.Enabled = true;

            if (reception == "f")
            {
                return;
            }

            else
            {
                for(int i = 0 ; i < tableLayoutPanelPlateauJeu.Controls.Count ; i++)
                {
                    if(tableLayoutPanelPlateauJeu.Controls[i].Text == reception)
                    {
                        tableLayoutPanelPlateauJeu.Controls[i].ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
