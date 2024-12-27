namespace ProjetGroupe5
{
    partial class InscriptionUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscriptionUtilisateur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreAd = new System.Windows.Forms.Label();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.btnCompteUtil = new System.Windows.Forms.Button();
            this.btnEffacerUtil = new System.Windows.Forms.Button();
            this.btnDectectUtil = new System.Windows.Forms.Button();
            this.cmbSexeUtil = new System.Windows.Forms.ComboBox();
            this.txtTelUtil = new System.Windows.Forms.TextBox();
            this.txtPrenomUtil = new System.Windows.Forms.TextBox();
            this.txtNomUtil = new System.Windows.Forms.TextBox();
            this.txtMatriculeUtil = new System.Windows.Forms.TextBox();
            this.txtPasswordUtil = new System.Windows.Forms.TextBox();
            this.lblMatU = new System.Windows.Forms.Label();
            this.lblSexeUtil = new System.Windows.Forms.Label();
            this.lblPassU = new System.Windows.Forms.Label();
            this.lblTelUtil = new System.Windows.Forms.Label();
            this.lblPrenomUtil = new System.Windows.Forms.Label();
            this.lblNomUtil = new System.Windows.Forms.Label();
            this.btnLancerRecognizUtil = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.lblTitreAd);
            this.panel1.Controls.Add(this.lblQuitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 46);
            this.panel1.TabIndex = 39;
            // 
            // lblTitreAd
            // 
            this.lblTitreAd.AutoSize = true;
            this.lblTitreAd.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAd.ForeColor = System.Drawing.Color.White;
            this.lblTitreAd.Location = new System.Drawing.Point(12, 11);
            this.lblTitreAd.Name = "lblTitreAd";
            this.lblTitreAd.Size = new System.Drawing.Size(227, 18);
            this.lblTitreAd.TabIndex = 1;
            this.lblTitreAd.Text = "INSCRIPTION UTILISATEUR";
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuitter.ForeColor = System.Drawing.Color.White;
            this.lblQuitter.Location = new System.Drawing.Point(586, 11);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(23, 21);
            this.lblQuitter.TabIndex = 0;
            this.lblQuitter.Text = "X";
            this.lblQuitter.Click += new System.EventHandler(this.lblQuitter_Click);
            // 
            // btnCompteUtil
            // 
            this.btnCompteUtil.BackColor = System.Drawing.Color.Teal;
            this.btnCompteUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompteUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompteUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnCompteUtil.ForeColor = System.Drawing.Color.White;
            this.btnCompteUtil.Location = new System.Drawing.Point(457, 610);
            this.btnCompteUtil.Name = "btnCompteUtil";
            this.btnCompteUtil.Size = new System.Drawing.Size(156, 46);
            this.btnCompteUtil.TabIndex = 36;
            this.btnCompteUtil.Text = "Créer Compte";
            this.btnCompteUtil.UseVisualStyleBackColor = false;
            this.btnCompteUtil.Click += new System.EventHandler(this.btnCompteUtil_Click);
            // 
            // btnEffacerUtil
            // 
            this.btnEffacerUtil.BackColor = System.Drawing.Color.Teal;
            this.btnEffacerUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacerUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacerUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnEffacerUtil.ForeColor = System.Drawing.Color.White;
            this.btnEffacerUtil.Location = new System.Drawing.Point(33, 610);
            this.btnEffacerUtil.Name = "btnEffacerUtil";
            this.btnEffacerUtil.Size = new System.Drawing.Size(206, 46);
            this.btnEffacerUtil.TabIndex = 37;
            this.btnEffacerUtil.Text = "Effacer";
            this.btnEffacerUtil.UseVisualStyleBackColor = false;
            this.btnEffacerUtil.Click += new System.EventHandler(this.btnEffacerUtil_Click);
            // 
            // btnDectectUtil
            // 
            this.btnDectectUtil.BackColor = System.Drawing.Color.Teal;
            this.btnDectectUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDectectUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDectectUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnDectectUtil.ForeColor = System.Drawing.Color.White;
            this.btnDectectUtil.Location = new System.Drawing.Point(245, 610);
            this.btnDectectUtil.Name = "btnDectectUtil";
            this.btnDectectUtil.Size = new System.Drawing.Size(206, 46);
            this.btnDectectUtil.TabIndex = 38;
            this.btnDectectUtil.Text = "Detection Faciale";
            this.btnDectectUtil.UseVisualStyleBackColor = false;
            this.btnDectectUtil.Click += new System.EventHandler(this.btnDectectUtil_Click);
            // 
            // cmbSexeUtil
            // 
            this.cmbSexeUtil.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculin",
            "Feminin"});
            this.cmbSexeUtil.FormattingEnabled = true;
            this.cmbSexeUtil.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbSexeUtil.Location = new System.Drawing.Point(46, 505);
            this.cmbSexeUtil.Name = "cmbSexeUtil";
            this.cmbSexeUtil.Size = new System.Drawing.Size(121, 24);
            this.cmbSexeUtil.TabIndex = 35;
            // 
            // txtTelUtil
            // 
            this.txtTelUtil.Location = new System.Drawing.Point(44, 427);
            this.txtTelUtil.Multiline = true;
            this.txtTelUtil.Name = "txtTelUtil";
            this.txtTelUtil.Size = new System.Drawing.Size(206, 28);
            this.txtTelUtil.TabIndex = 28;
            // 
            // txtPrenomUtil
            // 
            this.txtPrenomUtil.Location = new System.Drawing.Point(44, 351);
            this.txtPrenomUtil.Multiline = true;
            this.txtPrenomUtil.Name = "txtPrenomUtil";
            this.txtPrenomUtil.Size = new System.Drawing.Size(206, 28);
            this.txtPrenomUtil.TabIndex = 29;
            // 
            // txtNomUtil
            // 
            this.txtNomUtil.Location = new System.Drawing.Point(46, 280);
            this.txtNomUtil.Multiline = true;
            this.txtNomUtil.Name = "txtNomUtil";
            this.txtNomUtil.Size = new System.Drawing.Size(206, 28);
            this.txtNomUtil.TabIndex = 30;
            // 
            // txtMatriculeUtil
            // 
            this.txtMatriculeUtil.Location = new System.Drawing.Point(46, 200);
            this.txtMatriculeUtil.Multiline = true;
            this.txtMatriculeUtil.Name = "txtMatriculeUtil";
            this.txtMatriculeUtil.Size = new System.Drawing.Size(206, 28);
            this.txtMatriculeUtil.TabIndex = 31;
            // 
            // txtPasswordUtil
            // 
            this.txtPasswordUtil.Location = new System.Drawing.Point(50, 117);
            this.txtPasswordUtil.Multiline = true;
            this.txtPasswordUtil.Name = "txtPasswordUtil";
            this.txtPasswordUtil.PasswordChar = '#';
            this.txtPasswordUtil.Size = new System.Drawing.Size(206, 28);
            this.txtPasswordUtil.TabIndex = 32;
            this.txtPasswordUtil.TextChanged += new System.EventHandler(this.txtPasswordUtil_TextChanged);
            // 
            // lblMatU
            // 
            this.lblMatU.AutoSize = true;
            this.lblMatU.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblMatU.Location = new System.Drawing.Point(47, 171);
            this.lblMatU.Name = "lblMatU";
            this.lblMatU.Size = new System.Drawing.Size(85, 17);
            this.lblMatU.TabIndex = 22;
            this.lblMatU.Text = "Matricule : ";
            // 
            // lblSexeUtil
            // 
            this.lblSexeUtil.AutoSize = true;
            this.lblSexeUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSexeUtil.Location = new System.Drawing.Point(43, 471);
            this.lblSexeUtil.Name = "lblSexeUtil";
            this.lblSexeUtil.Size = new System.Drawing.Size(53, 17);
            this.lblSexeUtil.TabIndex = 23;
            this.lblSexeUtil.Text = "Sexe : ";
            // 
            // lblPassU
            // 
            this.lblPassU.AutoSize = true;
            this.lblPassU.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPassU.Location = new System.Drawing.Point(49, 83);
            this.lblPassU.Name = "lblPassU";
            this.lblPassU.Size = new System.Drawing.Size(83, 17);
            this.lblPassU.TabIndex = 24;
            this.lblPassU.Text = "Password : ";
            // 
            // lblTelUtil
            // 
            this.lblTelUtil.AutoSize = true;
            this.lblTelUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTelUtil.Location = new System.Drawing.Point(43, 396);
            this.lblTelUtil.Name = "lblTelUtil";
            this.lblTelUtil.Size = new System.Drawing.Size(87, 17);
            this.lblTelUtil.TabIndex = 25;
            this.lblTelUtil.Text = "Téléphone :";
            // 
            // lblPrenomUtil
            // 
            this.lblPrenomUtil.AutoSize = true;
            this.lblPrenomUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPrenomUtil.Location = new System.Drawing.Point(43, 328);
            this.lblPrenomUtil.Name = "lblPrenomUtil";
            this.lblPrenomUtil.Size = new System.Drawing.Size(68, 17);
            this.lblPrenomUtil.TabIndex = 26;
            this.lblPrenomUtil.Text = "Prenom :";
            // 
            // lblNomUtil
            // 
            this.lblNomUtil.AutoSize = true;
            this.lblNomUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNomUtil.Location = new System.Drawing.Point(47, 250);
            this.lblNomUtil.Name = "lblNomUtil";
            this.lblNomUtil.Size = new System.Drawing.Size(48, 17);
            this.lblNomUtil.TabIndex = 27;
            this.lblNomUtil.Text = "Nom :";
            // 
            // btnLancerRecognizUtil
            // 
            this.btnLancerRecognizUtil.BackColor = System.Drawing.Color.Teal;
            this.btnLancerRecognizUtil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancerRecognizUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancerRecognizUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnLancerRecognizUtil.ForeColor = System.Drawing.Color.White;
            this.btnLancerRecognizUtil.Location = new System.Drawing.Point(33, 549);
            this.btnLancerRecognizUtil.Name = "btnLancerRecognizUtil";
            this.btnLancerRecognizUtil.Size = new System.Drawing.Size(206, 46);
            this.btnLancerRecognizUtil.TabIndex = 38;
            this.btnLancerRecognizUtil.Text = "Démarrer Enregistrement";
            this.btnLancerRecognizUtil.UseVisualStyleBackColor = false;
            this.btnLancerRecognizUtil.Click += new System.EventHandler(this.btnLancerRecognizUtil_Click);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Location = new System.Drawing.Point(269, 84);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(340, 251);
            this.pic1.TabIndex = 40;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2.Location = new System.Drawing.Point(269, 341);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(233, 160);
            this.pic2.TabIndex = 40;
            this.pic2.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(0, 47);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(43, 34);
            this.btnRetour.TabIndex = 41;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(50, 154);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 17);
            this.lbl_info.TabIndex = 42;
            // 
            // InscriptionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 668);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompteUtil);
            this.Controls.Add(this.btnEffacerUtil);
            this.Controls.Add(this.btnLancerRecognizUtil);
            this.Controls.Add(this.btnDectectUtil);
            this.Controls.Add(this.cmbSexeUtil);
            this.Controls.Add(this.txtTelUtil);
            this.Controls.Add(this.txtPrenomUtil);
            this.Controls.Add(this.txtNomUtil);
            this.Controls.Add(this.txtMatriculeUtil);
            this.Controls.Add(this.txtPasswordUtil);
            this.Controls.Add(this.lblMatU);
            this.Controls.Add(this.lblSexeUtil);
            this.Controls.Add(this.lblPassU);
            this.Controls.Add(this.lblTelUtil);
            this.Controls.Add(this.lblPrenomUtil);
            this.Controls.Add(this.lblNomUtil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InscriptionUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InscriptionUtilisateur";
            this.Load += new System.EventHandler(this.InscriptionUtilisateur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreAd;
        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Button btnCompteUtil;
        private System.Windows.Forms.Button btnEffacerUtil;
        private System.Windows.Forms.Button btnDectectUtil;
        private System.Windows.Forms.ComboBox cmbSexeUtil;
        private System.Windows.Forms.TextBox txtTelUtil;
        private System.Windows.Forms.TextBox txtPrenomUtil;
        private System.Windows.Forms.TextBox txtNomUtil;
        private System.Windows.Forms.TextBox txtMatriculeUtil;
        private System.Windows.Forms.TextBox txtPasswordUtil;
        private System.Windows.Forms.Label lblMatU;
        private System.Windows.Forms.Label lblSexeUtil;
        private System.Windows.Forms.Label lblPassU;
        private System.Windows.Forms.Label lblTelUtil;
        private System.Windows.Forms.Label lblPrenomUtil;
        private System.Windows.Forms.Label lblNomUtil;
        private System.Windows.Forms.Button btnLancerRecognizUtil;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lbl_info;
    }
}