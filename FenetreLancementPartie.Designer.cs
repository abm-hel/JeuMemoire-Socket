
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
            this.buttonSeConnecter = new System.Windows.Forms.Button();
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
            this.buttonCommencerPartie.Click += new System.EventHandler(this.buttonCommencerPartie_Click);
            // 
            // buttonSeConnecter
            // 
            this.buttonSeConnecter.Location = new System.Drawing.Point(43, 70);
            this.buttonSeConnecter.Name = "buttonSeConnecter";
            this.buttonSeConnecter.Size = new System.Drawing.Size(196, 31);
            this.buttonSeConnecter.TabIndex = 2;
            this.buttonSeConnecter.Text = "Se connecter";
            this.buttonSeConnecter.UseVisualStyleBackColor = true;
            this.buttonSeConnecter.Click += new System.EventHandler(this.buttonSeConnecter_Click);
            // 
            // textBoxAdresseIP
            // 
            this.textBoxAdresseIP.Location = new System.Drawing.Point(70, 33);
            this.textBoxAdresseIP.Name = "textBoxAdresseIP";
            this.textBoxAdresseIP.Size = new System.Drawing.Size(149, 22);
            this.textBoxAdresseIP.TabIndex = 1;
            this.textBoxAdresseIP.Text = "localhost";
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
            this.groupBoxRejoindrePartie.Controls.Add(this.buttonSeConnecter);
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
        private System.Windows.Forms.Button buttonSeConnecter;
        private System.Windows.Forms.TextBox textBoxAdresseIP;
        private System.Windows.Forms.Label labelAdresseIP;
        private System.Windows.Forms.GroupBox groupBoxRejoindrePartie;
    }
}