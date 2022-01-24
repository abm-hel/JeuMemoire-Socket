
namespace JeuMemoire_Socket
{
    partial class FenetreLancementPartie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCommencerPartie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAdresseIP = new System.Windows.Forms.TextBox();
            this.labelAdresseIP = new System.Windows.Forms.Label();
            this.groupBoxRejoindrePartie = new System.Windows.Forms.GroupBox();
            this.groupBoxRejoindrePartie.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCommencerPartie
            // 
            this.buttonCommencerPartie.Location = new System.Drawing.Point(12, 150);
            this.buttonCommencerPartie.Name = "buttonCommencerPartie";
            this.buttonCommencerPartie.Size = new System.Drawing.Size(261, 31);
            this.buttonCommencerPartie.TabIndex = 5;
            this.buttonCommencerPartie.Text = "Commencer une partie";
            this.buttonCommencerPartie.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxAdresseIP
            // 
            this.textBoxAdresseIP.Location = new System.Drawing.Point(70, 33);
            this.textBoxAdresseIP.Name = "textBoxAdresseIP";
            this.textBoxAdresseIP.Size = new System.Drawing.Size(149, 22);
            this.textBoxAdresseIP.TabIndex = 1;
            // 
            // labelAdresseIP
            // 
            this.labelAdresseIP.AutoSize = true;
            this.labelAdresseIP.Location = new System.Drawing.Point(40, 36);
            this.labelAdresseIP.Name = "labelAdresseIP";
            this.labelAdresseIP.Size = new System.Drawing.Size(24, 17);
            this.labelAdresseIP.TabIndex = 0;
            this.labelAdresseIP.Text = "IP:";
            // 
            // groupBoxRejoindrePartie
            // 
            this.groupBoxRejoindrePartie.Controls.Add(this.button1);
            this.groupBoxRejoindrePartie.Controls.Add(this.textBoxAdresseIP);
            this.groupBoxRejoindrePartie.Controls.Add(this.labelAdresseIP);
            this.groupBoxRejoindrePartie.Location = new System.Drawing.Point(12, 13);
            this.groupBoxRejoindrePartie.Name = "groupBoxRejoindrePartie";
            this.groupBoxRejoindrePartie.Size = new System.Drawing.Size(261, 119);
            this.groupBoxRejoindrePartie.TabIndex = 4;
            this.groupBoxRejoindrePartie.TabStop = false;
            this.groupBoxRejoindrePartie.Text = "Rejoindre une partie";
            // 
            // FenetreLancementPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 198);
            this.Controls.Add(this.buttonCommencerPartie);
            this.Controls.Add(this.groupBoxRejoindrePartie);
            this.Name = "FenetreLancementPartie";
            this.Text = "Partie";
            this.groupBoxRejoindrePartie.ResumeLayout(false);
            this.groupBoxRejoindrePartie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCommencerPartie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAdresseIP;
        private System.Windows.Forms.Label labelAdresseIP;
        private System.Windows.Forms.GroupBox groupBoxRejoindrePartie;
    }
}