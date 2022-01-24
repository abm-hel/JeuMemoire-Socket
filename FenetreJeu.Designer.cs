
namespace JeuMemoire_Socket
{
    partial class FenetreJeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelPlateauJeu = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerJeu = new System.Windows.Forms.Timer(this.components);
            this.labelTest = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreAdversaire = new System.Windows.Forms.Label();
            this.labelS1 = new System.Windows.Forms.Label();
            this.labelS2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelPlateauJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPlateauJeu
            // 
            this.tableLayoutPanelPlateauJeu.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanelPlateauJeu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelPlateauJeu.ColumnCount = 4;
            this.tableLayoutPanelPlateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label16, 3, 3);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label12, 3, 2);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanelPlateauJeu.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanelPlateauJeu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelPlateauJeu.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanelPlateauJeu.Location = new System.Drawing.Point(0, 136);
            this.tableLayoutPanelPlateauJeu.Name = "tableLayoutPanelPlateauJeu";
            this.tableLayoutPanelPlateauJeu.RowCount = 4;
            this.tableLayoutPanelPlateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPlateauJeu.Size = new System.Drawing.Size(532, 467);
            this.tableLayoutPanelPlateauJeu.TabIndex = 0;
            this.tableLayoutPanelPlateauJeu.Click += new System.EventHandler(this.selectionCase);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(5, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 115);
            this.label13.TabIndex = 0;
            this.label13.Text = "x";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.selectionCase);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(137, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 115);
            this.label14.TabIndex = 1;
            this.label14.Text = "x";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.selectionCase);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(269, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 115);
            this.label15.TabIndex = 3;
            this.label15.Text = "x";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.selectionCase);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(5, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 114);
            this.label9.TabIndex = 8;
            this.label9.Text = "x";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.selectionCase);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Black;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(401, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 115);
            this.label16.TabIndex = 2;
            this.label16.Text = "x";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.selectionCase);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(137, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 114);
            this.label10.TabIndex = 9;
            this.label10.Text = "x";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.selectionCase);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(269, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 114);
            this.label11.TabIndex = 11;
            this.label11.Text = "x";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.selectionCase);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(137, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 114);
            this.label6.TabIndex = 13;
            this.label6.Text = "x";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.selectionCase);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 114);
            this.label2.TabIndex = 15;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.selectionCase);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 114);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.selectionCase);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(401, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 114);
            this.label12.TabIndex = 6;
            this.label12.Text = "x";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.selectionCase);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(401, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 114);
            this.label8.TabIndex = 14;
            this.label8.Text = "x";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.selectionCase);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 114);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.selectionCase);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(269, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 114);
            this.label7.TabIndex = 10;
            this.label7.Text = "x";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.selectionCase);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(401, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 114);
            this.label4.TabIndex = 7;
            this.label4.Text = "x";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.selectionCase);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 114);
            this.label5.TabIndex = 12;
            this.label5.Text = "x";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.selectionCase);
            // 
            // timerJeu
            // 
            this.timerJeu.Interval = 750;
            this.timerJeu.Tick += new System.EventHandler(this.timerJeu_Tick);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTest.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTest.Location = new System.Drawing.Point(12, 9);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(62, 29);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "tour";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.DarkRed;
            this.labelScore.Location = new System.Drawing.Point(416, 53);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(28, 29);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // labelScoreAdversaire
            // 
            this.labelScoreAdversaire.AutoSize = true;
            this.labelScoreAdversaire.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreAdversaire.ForeColor = System.Drawing.Color.DarkRed;
            this.labelScoreAdversaire.Location = new System.Drawing.Point(416, 91);
            this.labelScoreAdversaire.Name = "labelScoreAdversaire";
            this.labelScoreAdversaire.Size = new System.Drawing.Size(28, 29);
            this.labelScoreAdversaire.TabIndex = 3;
            this.labelScoreAdversaire.Text = "0";
            // 
            // labelS1
            // 
            this.labelS1.AutoSize = true;
            this.labelS1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS1.ForeColor = System.Drawing.Color.DarkRed;
            this.labelS1.Location = new System.Drawing.Point(12, 53);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(177, 29);
            this.labelS1.TabIndex = 4;
            this.labelS1.Text = "Votre score : ";
            // 
            // labelS2
            // 
            this.labelS2.AutoSize = true;
            this.labelS2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS2.ForeColor = System.Drawing.Color.DarkRed;
            this.labelS2.Location = new System.Drawing.Point(12, 91);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(374, 29);
            this.labelS2.TabIndex = 5;
            this.labelS2.Text = "Le Score de votre adversaire :";
            // 
            // FenetreJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(532, 603);
            this.Controls.Add(this.labelS2);
            this.Controls.Add(this.labelS1);
            this.Controls.Add(this.labelScoreAdversaire);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.tableLayoutPanelPlateauJeu);
            this.Name = "FenetreJeu";
            this.Text = "Jeu de mémoire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FenetreJeu_FormClosing);
            this.tableLayoutPanelPlateauJeu.ResumeLayout(false);
            this.tableLayoutPanelPlateauJeu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlateauJeu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerJeu;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreAdversaire;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.Label labelS2;
    }
}

