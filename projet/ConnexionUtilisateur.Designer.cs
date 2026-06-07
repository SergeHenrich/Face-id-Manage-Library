namespace ProjetGroupe5
{
    partial class ConnexionUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionUtilisateur));
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnConnexionUtil = new System.Windows.Forms.Button();
            this.btnCréerCompte = new System.Windows.Forms.Button();
            this.btnLancerRecognizUtil = new System.Windows.Forms.Button();
            this.txtNomUtilConnex = new System.Windows.Forms.TextBox();
            this.txtPasswordUtilConnex = new System.Windows.Forms.TextBox();
            this.lblPasswordUtilConnex = new System.Windows.Forms.Label();
            this.lblNomUtilConnex = new System.Windows.Forms.Label();
            this.pnlTitreCU = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitreUtil = new System.Windows.Forms.Label();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.lblVoirMP = new System.Windows.Forms.Label();
            this.cameraBox2 = new Emgu.CV.UI.ImageBox();
            this.pnlTitreCU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnEffacer.Location = new System.Drawing.Point(52, 359);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(136, 46);
            this.btnEffacer.TabIndex = 41;
            this.btnEffacer.Text = "Arrêter Camera";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnConnexionUtil
            // 
            this.btnConnexionUtil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConnexionUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexionUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexionUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnConnexionUtil.Location = new System.Drawing.Point(203, 424);
            this.btnConnexionUtil.Name = "btnConnexionUtil";
            this.btnConnexionUtil.Size = new System.Drawing.Size(235, 46);
            this.btnConnexionUtil.TabIndex = 38;
            this.btnConnexionUtil.Text = "Se Connecter";
            this.btnConnexionUtil.UseVisualStyleBackColor = false;
            this.btnConnexionUtil.Click += new System.EventHandler(this.btnConnexionUtil_Click);
            // 
            // btnCréerCompte
            // 
            this.btnCréerCompte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCréerCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCréerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCréerCompte.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnCréerCompte.Location = new System.Drawing.Point(449, 359);
            this.btnCréerCompte.Name = "btnCréerCompte";
            this.btnCréerCompte.Size = new System.Drawing.Size(167, 46);
            this.btnCréerCompte.TabIndex = 39;
            this.btnCréerCompte.Text = "Créer Compte";
            this.btnCréerCompte.UseVisualStyleBackColor = false;
            this.btnCréerCompte.Click += new System.EventHandler(this.btnCréerCompte_Click);
            // 
            // btnLancerRecognizUtil
            // 
            this.btnLancerRecognizUtil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLancerRecognizUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancerRecognizUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancerRecognizUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnLancerRecognizUtil.Location = new System.Drawing.Point(215, 359);
            this.btnLancerRecognizUtil.Name = "btnLancerRecognizUtil";
            this.btnLancerRecognizUtil.Size = new System.Drawing.Size(206, 46);
            this.btnLancerRecognizUtil.TabIndex = 40;
            this.btnLancerRecognizUtil.Text = "Lancer Reconnaissance";
            this.btnLancerRecognizUtil.UseVisualStyleBackColor = false;
            this.btnLancerRecognizUtil.Click += new System.EventHandler(this.btnLancerRecognizUtil_Click);
            // 
            // txtNomUtilConnex
            // 
            this.txtNomUtilConnex.Location = new System.Drawing.Point(96, 119);
            this.txtNomUtilConnex.Multiline = true;
            this.txtNomUtilConnex.Name = "txtNomUtilConnex";
            this.txtNomUtilConnex.Size = new System.Drawing.Size(206, 28);
            this.txtNomUtilConnex.TabIndex = 35;
            // 
            // txtPasswordUtilConnex
            // 
            this.txtPasswordUtilConnex.Location = new System.Drawing.Point(96, 194);
            this.txtPasswordUtilConnex.Multiline = true;
            this.txtPasswordUtilConnex.Name = "txtPasswordUtilConnex";
            this.txtPasswordUtilConnex.PasswordChar = '#';
            this.txtPasswordUtilConnex.Size = new System.Drawing.Size(206, 28);
            this.txtPasswordUtilConnex.TabIndex = 36;
            // 
            // lblPasswordUtilConnex
            // 
            this.lblPasswordUtilConnex.AutoSize = true;
            this.lblPasswordUtilConnex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPasswordUtilConnex.Location = new System.Drawing.Point(7, 205);
            this.lblPasswordUtilConnex.Name = "lblPasswordUtilConnex";
            this.lblPasswordUtilConnex.Size = new System.Drawing.Size(83, 17);
            this.lblPasswordUtilConnex.TabIndex = 33;
            this.lblPasswordUtilConnex.Text = "Password : ";
            // 
            // lblNomUtilConnex
            // 
            this.lblNomUtilConnex.AutoSize = true;
            this.lblNomUtilConnex.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNomUtilConnex.Location = new System.Drawing.Point(7, 130);
            this.lblNomUtilConnex.Name = "lblNomUtilConnex";
            this.lblNomUtilConnex.Size = new System.Drawing.Size(48, 17);
            this.lblNomUtilConnex.TabIndex = 34;
            this.lblNomUtilConnex.Text = "Nom :";
            // 
            // pnlTitreCU
            // 
            this.pnlTitreCU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.pnlTitreCU.Controls.Add(this.pictureBox1);
            this.pnlTitreCU.Controls.Add(this.lblTitreUtil);
            this.pnlTitreCU.Controls.Add(this.lblQuitter);
            this.pnlTitreCU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitreCU.Location = new System.Drawing.Point(0, 0);
            this.pnlTitreCU.Name = "pnlTitreCU";
            this.pnlTitreCU.Size = new System.Drawing.Size(685, 58);
            this.pnlTitreCU.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitreUtil
            // 
            this.lblTitreUtil.AutoSize = true;
            this.lblTitreUtil.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreUtil.ForeColor = System.Drawing.Color.White;
            this.lblTitreUtil.Location = new System.Drawing.Point(70, 19);
            this.lblTitreUtil.Name = "lblTitreUtil";
            this.lblTitreUtil.Size = new System.Drawing.Size(221, 18);
            this.lblTitreUtil.TabIndex = 3;
            this.lblTitreUtil.Text = "CONNEXION UTILISATEUR";
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuitter.ForeColor = System.Drawing.Color.White;
            this.lblQuitter.Location = new System.Drawing.Point(650, 16);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(23, 21);
            this.lblQuitter.TabIndex = 2;
            this.lblQuitter.Text = "X";
            this.lblQuitter.Click += new System.EventHandler(this.lblQuitter_Click);
            // 
            // lblVoirMP
            // 
            this.lblVoirMP.AutoSize = true;
            this.lblVoirMP.Location = new System.Drawing.Point(7, 263);
            this.lblVoirMP.Name = "lblVoirMP";
            this.lblVoirMP.Size = new System.Drawing.Size(0, 17);
            this.lblVoirMP.TabIndex = 43;
            // 
            // cameraBox2
            // 
            this.cameraBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cameraBox2.Location = new System.Drawing.Point(308, 64);
            this.cameraBox2.Name = "cameraBox2";
            this.cameraBox2.Size = new System.Drawing.Size(365, 279);
            this.cameraBox2.TabIndex = 2;
            this.cameraBox2.TabStop = false;
            // 
            // ConnexionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 479);
            this.Controls.Add(this.cameraBox2);
            this.Controls.Add(this.lblVoirMP);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnConnexionUtil);
            this.Controls.Add(this.btnCréerCompte);
            this.Controls.Add(this.btnLancerRecognizUtil);
            this.Controls.Add(this.txtNomUtilConnex);
            this.Controls.Add(this.txtPasswordUtilConnex);
            this.Controls.Add(this.lblPasswordUtilConnex);
            this.Controls.Add(this.lblNomUtilConnex);
            this.Controls.Add(this.pnlTitreCU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnexionUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnexionUtilisateur";
            this.pnlTitreCU.ResumeLayout(false);
            this.pnlTitreCU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnConnexionUtil;
        private System.Windows.Forms.Button btnCréerCompte;
        private System.Windows.Forms.Button btnLancerRecognizUtil;
        private System.Windows.Forms.TextBox txtNomUtilConnex;
        private System.Windows.Forms.TextBox txtPasswordUtilConnex;
        private System.Windows.Forms.Label lblPasswordUtilConnex;
        private System.Windows.Forms.Label lblNomUtilConnex;
        private System.Windows.Forms.Panel pnlTitreCU;
        private System.Windows.Forms.Label lblTitreUtil;
        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Label lblVoirMP;
        private Emgu.CV.UI.ImageBox cameraBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}