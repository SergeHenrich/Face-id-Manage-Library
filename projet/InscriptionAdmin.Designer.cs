namespace ProjetGroupe5
{
    partial class InscriptionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscriptionAdmin));
            this.btnCompteAd = new System.Windows.Forms.Button();
            this.btnEffacerAd = new System.Windows.Forms.Button();
            this.btnLancerRecognizAd = new System.Windows.Forms.Button();
            this.cmbSexeAd = new System.Windows.Forms.ComboBox();
            this.txtTelAd = new System.Windows.Forms.TextBox();
            this.txtPrenomAd = new System.Windows.Forms.TextBox();
            this.txtNomAd = new System.Windows.Forms.TextBox();
            this.txtCodeAd = new System.Windows.Forms.TextBox();
            this.lblSexeAd = new System.Windows.Forms.Label();
            this.lblCodeAd = new System.Windows.Forms.Label();
            this.lblTelAd = new System.Windows.Forms.Label();
            this.lblPrenomAd = new System.Windows.Forms.Label();
            this.lblNomAd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitreAd = new System.Windows.Forms.Label();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.btnDetectAd = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompteAd
            // 
            this.btnCompteAd.BackColor = System.Drawing.Color.Teal;
            this.btnCompteAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompteAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompteAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnCompteAd.ForeColor = System.Drawing.Color.White;
            this.btnCompteAd.Location = new System.Drawing.Point(470, 563);
            this.btnCompteAd.Name = "btnCompteAd";
            this.btnCompteAd.Size = new System.Drawing.Size(156, 46);
            this.btnCompteAd.TabIndex = 18;
            this.btnCompteAd.Text = "Créer Compte";
            this.btnCompteAd.UseVisualStyleBackColor = false;
            this.btnCompteAd.Click += new System.EventHandler(this.btnCompteAd_Click);
            // 
            // btnEffacerAd
            // 
            this.btnEffacerAd.BackColor = System.Drawing.Color.Teal;
            this.btnEffacerAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacerAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacerAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnEffacerAd.ForeColor = System.Drawing.Color.White;
            this.btnEffacerAd.Location = new System.Drawing.Point(31, 563);
            this.btnEffacerAd.Name = "btnEffacerAd";
            this.btnEffacerAd.Size = new System.Drawing.Size(212, 46);
            this.btnEffacerAd.TabIndex = 19;
            this.btnEffacerAd.Text = "Effacer";
            this.btnEffacerAd.UseVisualStyleBackColor = false;
            this.btnEffacerAd.Click += new System.EventHandler(this.btnEffacerAd_Click);
            // 
            // btnLancerRecognizAd
            // 
            this.btnLancerRecognizAd.BackColor = System.Drawing.Color.Teal;
            this.btnLancerRecognizAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancerRecognizAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancerRecognizAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnLancerRecognizAd.ForeColor = System.Drawing.Color.White;
            this.btnLancerRecognizAd.Location = new System.Drawing.Point(31, 496);
            this.btnLancerRecognizAd.Name = "btnLancerRecognizAd";
            this.btnLancerRecognizAd.Size = new System.Drawing.Size(212, 51);
            this.btnLancerRecognizAd.TabIndex = 20;
            this.btnLancerRecognizAd.Text = "Démarrer Enregistrement";
            this.btnLancerRecognizAd.UseVisualStyleBackColor = false;
            this.btnLancerRecognizAd.Click += new System.EventHandler(this.btnLancerRecognizAd_Click);
            // 
            // cmbSexeAd
            // 
            this.cmbSexeAd.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculin",
            "Feminin"});
            this.cmbSexeAd.FormattingEnabled = true;
            this.cmbSexeAd.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbSexeAd.Location = new System.Drawing.Point(33, 440);
            this.cmbSexeAd.Name = "cmbSexeAd";
            this.cmbSexeAd.Size = new System.Drawing.Size(121, 24);
            this.cmbSexeAd.TabIndex = 17;
            // 
            // txtTelAd
            // 
            this.txtTelAd.Location = new System.Drawing.Point(31, 362);
            this.txtTelAd.Multiline = true;
            this.txtTelAd.Name = "txtTelAd";
            this.txtTelAd.Size = new System.Drawing.Size(212, 28);
            this.txtTelAd.TabIndex = 11;
            // 
            // txtPrenomAd
            // 
            this.txtPrenomAd.Location = new System.Drawing.Point(31, 286);
            this.txtPrenomAd.Multiline = true;
            this.txtPrenomAd.Name = "txtPrenomAd";
            this.txtPrenomAd.Size = new System.Drawing.Size(212, 28);
            this.txtPrenomAd.TabIndex = 12;
            // 
            // txtNomAd
            // 
            this.txtNomAd.Location = new System.Drawing.Point(33, 215);
            this.txtNomAd.Multiline = true;
            this.txtNomAd.Name = "txtNomAd";
            this.txtNomAd.Size = new System.Drawing.Size(210, 28);
            this.txtNomAd.TabIndex = 13;
            // 
            // txtCodeAd
            // 
            this.txtCodeAd.Location = new System.Drawing.Point(37, 139);
            this.txtCodeAd.Multiline = true;
            this.txtCodeAd.Name = "txtCodeAd";
            this.txtCodeAd.PasswordChar = '#';
            this.txtCodeAd.Size = new System.Drawing.Size(206, 28);
            this.txtCodeAd.TabIndex = 15;
            this.txtCodeAd.TextChanged += new System.EventHandler(this.txtCodeAd_TextChanged);
            // 
            // lblSexeAd
            // 
            this.lblSexeAd.AutoSize = true;
            this.lblSexeAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSexeAd.Location = new System.Drawing.Point(30, 406);
            this.lblSexeAd.Name = "lblSexeAd";
            this.lblSexeAd.Size = new System.Drawing.Size(53, 17);
            this.lblSexeAd.TabIndex = 6;
            this.lblSexeAd.Text = "Sexe : ";
            // 
            // lblCodeAd
            // 
            this.lblCodeAd.AutoSize = true;
            this.lblCodeAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblCodeAd.Location = new System.Drawing.Point(34, 105);
            this.lblCodeAd.Name = "lblCodeAd";
            this.lblCodeAd.Size = new System.Drawing.Size(99, 17);
            this.lblCodeAd.TabIndex = 7;
            this.lblCodeAd.Text = "Code admin : ";
            // 
            // lblTelAd
            // 
            this.lblTelAd.AutoSize = true;
            this.lblTelAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTelAd.Location = new System.Drawing.Point(30, 331);
            this.lblTelAd.Name = "lblTelAd";
            this.lblTelAd.Size = new System.Drawing.Size(87, 17);
            this.lblTelAd.TabIndex = 8;
            this.lblTelAd.Text = "Téléphone :";
            // 
            // lblPrenomAd
            // 
            this.lblPrenomAd.AutoSize = true;
            this.lblPrenomAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblPrenomAd.Location = new System.Drawing.Point(30, 263);
            this.lblPrenomAd.Name = "lblPrenomAd";
            this.lblPrenomAd.Size = new System.Drawing.Size(68, 17);
            this.lblPrenomAd.TabIndex = 9;
            this.lblPrenomAd.Text = "Prenom :";
            // 
            // lblNomAd
            // 
            this.lblNomAd.AutoSize = true;
            this.lblNomAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNomAd.Location = new System.Drawing.Point(34, 185);
            this.lblNomAd.Name = "lblNomAd";
            this.lblNomAd.Size = new System.Drawing.Size(48, 17);
            this.lblNomAd.TabIndex = 10;
            this.lblNomAd.Text = "Nom :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.lblTitreAd);
            this.panel1.Controls.Add(this.lblQuitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 46);
            this.panel1.TabIndex = 21;
            // 
            // lblTitreAd
            // 
            this.lblTitreAd.AutoSize = true;
            this.lblTitreAd.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAd.ForeColor = System.Drawing.Color.White;
            this.lblTitreAd.Location = new System.Drawing.Point(12, 11);
            this.lblTitreAd.Name = "lblTitreAd";
            this.lblTitreAd.Size = new System.Drawing.Size(267, 18);
            this.lblTitreAd.TabIndex = 1;
            this.lblTitreAd.Text = "INSCRIPTION ADMINISTRATEUR";
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuitter.ForeColor = System.Drawing.Color.White;
            this.lblQuitter.Location = new System.Drawing.Point(605, 9);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(23, 21);
            this.lblQuitter.TabIndex = 0;
            this.lblQuitter.Text = "X";
            this.lblQuitter.Click += new System.EventHandler(this.lblQuitter_Click);
            // 
            // btnDetectAd
            // 
            this.btnDetectAd.BackColor = System.Drawing.Color.Teal;
            this.btnDetectAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetectAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetectAd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnDetectAd.ForeColor = System.Drawing.Color.White;
            this.btnDetectAd.Location = new System.Drawing.Point(258, 563);
            this.btnDetectAd.Name = "btnDetectAd";
            this.btnDetectAd.Size = new System.Drawing.Size(206, 46);
            this.btnDetectAd.TabIndex = 20;
            this.btnDetectAd.Text = "Detection Faciale";
            this.btnDetectAd.UseVisualStyleBackColor = false;
            this.btnDetectAd.Click += new System.EventHandler(this.btnDetectAd_Click);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic1.Location = new System.Drawing.Point(286, 77);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(340, 255);
            this.pic1.TabIndex = 22;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic2.Location = new System.Drawing.Point(286, 346);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(250, 156);
            this.pic2.TabIndex = 22;
            this.pic2.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(0, 46);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(52, 38);
            this.btnRetour.TabIndex = 23;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(37, 170);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 17);
            this.lbl_info.TabIndex = 24;
            // 
            // InscriptionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 621);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompteAd);
            this.Controls.Add(this.btnEffacerAd);
            this.Controls.Add(this.btnDetectAd);
            this.Controls.Add(this.btnLancerRecognizAd);
            this.Controls.Add(this.cmbSexeAd);
            this.Controls.Add(this.txtTelAd);
            this.Controls.Add(this.txtPrenomAd);
            this.Controls.Add(this.txtNomAd);
            this.Controls.Add(this.txtCodeAd);
            this.Controls.Add(this.lblSexeAd);
            this.Controls.Add(this.lblCodeAd);
            this.Controls.Add(this.lblTelAd);
            this.Controls.Add(this.lblPrenomAd);
            this.Controls.Add(this.lblNomAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InscriptionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InscriptionAdmin";
            this.Load += new System.EventHandler(this.InscriptionAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompteAd;
        private System.Windows.Forms.Button btnEffacerAd;
        private System.Windows.Forms.Button btnLancerRecognizAd;
        private System.Windows.Forms.ComboBox cmbSexeAd;
        private System.Windows.Forms.TextBox txtTelAd;
        private System.Windows.Forms.TextBox txtPrenomAd;
        private System.Windows.Forms.TextBox txtNomAd;
        private System.Windows.Forms.TextBox txtCodeAd;
        private System.Windows.Forms.Label lblSexeAd;
        private System.Windows.Forms.Label lblCodeAd;
        private System.Windows.Forms.Label lblTelAd;
        private System.Windows.Forms.Label lblPrenomAd;
        private System.Windows.Forms.Label lblNomAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreAd;
        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Button btnDetectAd;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lbl_info;
    }
}