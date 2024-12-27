namespace ProjetGroupe5
{
    partial class ConnexionAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionAdmin));
            this.pnlTitreCU = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoirLIcence = new System.Windows.Forms.Button();
            this.lblTitreAd = new System.Windows.Forms.Label();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnConnexionAd = new System.Windows.Forms.Button();
            this.btnLancerRecognizCAd = new System.Windows.Forms.Button();
            this.txtNomAdConnex = new System.Windows.Forms.TextBox();
            this.txtCodeAdConnex = new System.Windows.Forms.TextBox();
            this.lblCodeAdConnex = new System.Windows.Forms.Label();
            this.lblNomAdConnex = new System.Windows.Forms.Label();
            this.btnCréerCompte = new System.Windows.Forms.Button();
            this.lblVoirCode = new System.Windows.Forms.Label();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.pnlTitreCU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitreCU
            // 
            this.pnlTitreCU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.pnlTitreCU.Controls.Add(this.pictureBox1);
            this.pnlTitreCU.Controls.Add(this.btnVoirLIcence);
            this.pnlTitreCU.Controls.Add(this.lblTitreAd);
            this.pnlTitreCU.Controls.Add(this.lblQuitter);
            this.pnlTitreCU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitreCU.Location = new System.Drawing.Point(0, 0);
            this.pnlTitreCU.Name = "pnlTitreCU";
            this.pnlTitreCU.Size = new System.Drawing.Size(718, 58);
            this.pnlTitreCU.TabIndex = 0;
            this.pnlTitreCU.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitreCU_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoirLIcence
            // 
            this.btnVoirLIcence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoirLIcence.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoirLIcence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(196)))));
            this.btnVoirLIcence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirLIcence.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirLIcence.ForeColor = System.Drawing.Color.White;
            this.btnVoirLIcence.Location = new System.Drawing.Point(527, 14);
            this.btnVoirLIcence.Name = "btnVoirLIcence";
            this.btnVoirLIcence.Size = new System.Drawing.Size(132, 24);
            this.btnVoirLIcence.TabIndex = 34;
            this.btnVoirLIcence.Text = "Voir Licence";
            this.btnVoirLIcence.UseCompatibleTextRendering = true;
            this.btnVoirLIcence.UseVisualStyleBackColor = false;
            this.btnVoirLIcence.Click += new System.EventHandler(this.btnVoirLIcence_Click);
            // 
            // lblTitreAd
            // 
            this.lblTitreAd.AutoSize = true;
            this.lblTitreAd.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAd.ForeColor = System.Drawing.Color.White;
            this.lblTitreAd.Location = new System.Drawing.Point(73, 20);
            this.lblTitreAd.Name = "lblTitreAd";
            this.lblTitreAd.Size = new System.Drawing.Size(261, 18);
            this.lblTitreAd.TabIndex = 3;
            this.lblTitreAd.Text = "CONNEXION ADMINISTRATEUR";
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuitter.ForeColor = System.Drawing.Color.White;
            this.lblQuitter.Location = new System.Drawing.Point(683, 16);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(23, 21);
            this.lblQuitter.TabIndex = 2;
            this.lblQuitter.Text = "X";
            this.lblQuitter.Click += new System.EventHandler(this.lblQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnEffacer.Location = new System.Drawing.Point(74, 380);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(138, 46);
            this.btnEffacer.TabIndex = 30;
            this.btnEffacer.Text = "Arrêter Camera";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnConnexionAd
            // 
            this.btnConnexionAd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConnexionAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexionAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexionAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnConnexionAd.Location = new System.Drawing.Point(235, 451);
            this.btnConnexionAd.Name = "btnConnexionAd";
            this.btnConnexionAd.Size = new System.Drawing.Size(226, 46);
            this.btnConnexionAd.TabIndex = 28;
            this.btnConnexionAd.Text = "Se Connecter";
            this.btnConnexionAd.UseVisualStyleBackColor = false;
            this.btnConnexionAd.Click += new System.EventHandler(this.btnConnexionAd_Click);
            // 
            // btnLancerRecognizCAd
            // 
            this.btnLancerRecognizCAd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLancerRecognizCAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancerRecognizCAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancerRecognizCAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnLancerRecognizCAd.Location = new System.Drawing.Point(245, 380);
            this.btnLancerRecognizCAd.Name = "btnLancerRecognizCAd";
            this.btnLancerRecognizCAd.Size = new System.Drawing.Size(206, 46);
            this.btnLancerRecognizCAd.TabIndex = 29;
            this.btnLancerRecognizCAd.Text = "Lancer Reconnaissance";
            this.btnLancerRecognizCAd.UseVisualStyleBackColor = false;
            this.btnLancerRecognizCAd.Click += new System.EventHandler(this.btnLancerRecognizCAd_Click);
            // 
            // txtNomAdConnex
            // 
            this.txtNomAdConnex.Location = new System.Drawing.Point(112, 101);
            this.txtNomAdConnex.Multiline = true;
            this.txtNomAdConnex.Name = "txtNomAdConnex";
            this.txtNomAdConnex.Size = new System.Drawing.Size(206, 28);
            this.txtNomAdConnex.TabIndex = 25;
            // 
            // txtCodeAdConnex
            // 
            this.txtCodeAdConnex.Location = new System.Drawing.Point(112, 175);
            this.txtCodeAdConnex.Multiline = true;
            this.txtCodeAdConnex.Name = "txtCodeAdConnex";
            this.txtCodeAdConnex.PasswordChar = '#';
            this.txtCodeAdConnex.Size = new System.Drawing.Size(206, 28);
            this.txtCodeAdConnex.TabIndex = 26;
            // 
            // lblCodeAdConnex
            // 
            this.lblCodeAdConnex.AutoSize = true;
            this.lblCodeAdConnex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblCodeAdConnex.Location = new System.Drawing.Point(7, 186);
            this.lblCodeAdConnex.Name = "lblCodeAdConnex";
            this.lblCodeAdConnex.Size = new System.Drawing.Size(99, 17);
            this.lblCodeAdConnex.TabIndex = 23;
            this.lblCodeAdConnex.Text = "Code admin : ";
            // 
            // lblNomAdConnex
            // 
            this.lblNomAdConnex.AutoSize = true;
            this.lblNomAdConnex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNomAdConnex.Location = new System.Drawing.Point(7, 112);
            this.lblNomAdConnex.Name = "lblNomAdConnex";
            this.lblNomAdConnex.Size = new System.Drawing.Size(48, 17);
            this.lblNomAdConnex.TabIndex = 24;
            this.lblNomAdConnex.Text = "Nom :";
            // 
            // btnCréerCompte
            // 
            this.btnCréerCompte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCréerCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCréerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCréerCompte.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnCréerCompte.Location = new System.Drawing.Point(476, 380);
            this.btnCréerCompte.Name = "btnCréerCompte";
            this.btnCréerCompte.Size = new System.Drawing.Size(159, 46);
            this.btnCréerCompte.TabIndex = 29;
            this.btnCréerCompte.Text = "Créer Compte";
            this.btnCréerCompte.UseVisualStyleBackColor = false;
            this.btnCréerCompte.Click += new System.EventHandler(this.btnCréerCompte_Click);
            // 
            // lblVoirCode
            // 
            this.lblVoirCode.AutoSize = true;
            this.lblVoirCode.Location = new System.Drawing.Point(7, 263);
            this.lblVoirCode.Name = "lblVoirCode";
            this.lblVoirCode.Size = new System.Drawing.Size(0, 17);
            this.lblVoirCode.TabIndex = 32;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox1.Location = new System.Drawing.Point(324, 64);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(382, 295);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // ConnexionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 506);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.lblVoirCode);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnConnexionAd);
            this.Controls.Add(this.btnCréerCompte);
            this.Controls.Add(this.btnLancerRecognizCAd);
            this.Controls.Add(this.txtNomAdConnex);
            this.Controls.Add(this.txtCodeAdConnex);
            this.Controls.Add(this.lblCodeAdConnex);
            this.Controls.Add(this.lblNomAdConnex);
            this.Controls.Add(this.pnlTitreCU);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnexionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnexionAdmin";
            this.Load += new System.EventHandler(this.ConnexionAdmin_Load);
            this.pnlTitreCU.ResumeLayout(false);
            this.pnlTitreCU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitreCU;
        private System.Windows.Forms.Label lblTitreAd;
        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnConnexionAd;
        private System.Windows.Forms.Button btnLancerRecognizCAd;
        private System.Windows.Forms.TextBox txtNomAdConnex;
        private System.Windows.Forms.TextBox txtCodeAdConnex;
        private System.Windows.Forms.Label lblCodeAdConnex;
        private System.Windows.Forms.Label lblNomAdConnex;
        private System.Windows.Forms.Button btnCréerCompte;
        private System.Windows.Forms.Label lblVoirCode;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnVoirLIcence;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}