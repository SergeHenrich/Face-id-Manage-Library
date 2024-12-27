namespace ProjetGroupe5
{
    partial class Gestionnaires
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionnaires));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.lblGestionnaire = new System.Windows.Forms.Label();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.picAnim = new System.Windows.Forms.PictureBox();
            this.btnModifierLiv = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouterLiv = new System.Windows.Forms.Button();
            this.pnlAvailable = new System.Windows.Forms.Panel();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblNbreDispo = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.lblNbreEmprunter = new System.Windows.Forms.Label();
            this.lblEmprunter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbrePages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnneePublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblQte = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNomliv = new System.Windows.Forms.Label();
            this.lblAPublication = new System.Windows.Forms.Label();
            this.lblCodeliv = new System.Windows.Forms.Label();
            this.txtNPages = new System.Windows.Forms.TextBox();
            this.txtNomliv = new System.Windows.Forms.TextBox();
            this.txtCodeliv = new System.Windows.Forms.TextBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.txtAPublic = new System.Windows.Forms.TextBox();
            this.pnlTitre.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnim)).BeginInit();
            this.pnlAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.pnlTitre.Controls.Add(this.lblQuitter);
            this.pnlTitre.Controls.Add(this.lblGestionnaire);
            this.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitre.Location = new System.Drawing.Point(0, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(1359, 57);
            this.pnlTitre.TabIndex = 0;
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuitter.Location = new System.Drawing.Point(1324, 19);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(23, 21);
            this.lblQuitter.TabIndex = 1;
            this.lblQuitter.Text = "X";
            this.lblQuitter.Click += new System.EventHandler(this.lblQuitter_Click);
            // 
            // lblGestionnaire
            // 
            this.lblGestionnaire.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionnaire.ForeColor = System.Drawing.Color.White;
            this.lblGestionnaire.Location = new System.Drawing.Point(12, 18);
            this.lblGestionnaire.Name = "lblGestionnaire";
            this.lblGestionnaire.Size = new System.Drawing.Size(425, 27);
            this.lblGestionnaire.TabIndex = 0;
            this.lblGestionnaire.Text = "GESTIONNAIRES  ADMINISTRATEUR | MainForm";
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.pnlDashBoard.Controls.Add(this.button1);
            this.pnlDashBoard.Controls.Add(this.btnRapport);
            this.pnlDashBoard.Controls.Add(this.btnRetour);
            this.pnlDashBoard.Controls.Add(this.picAnim);
            this.pnlDashBoard.Controls.Add(this.btnModifierLiv);
            this.pnlDashBoard.Controls.Add(this.btnSupprimer);
            this.pnlDashBoard.Controls.Add(this.btnAjouterLiv);
            this.pnlDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashBoard.Location = new System.Drawing.Point(0, 57);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(175, 583);
            this.pnlDashBoard.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(16, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 64);
            this.button1.TabIndex = 37;
            this.button1.Text = "Rapport utilisateurs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnRapport
            // 
            this.btnRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapport.Location = new System.Drawing.Point(16, 345);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(138, 59);
            this.btnRapport.TabIndex = 37;
            this.btnRapport.Text = "Rapport  livres";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            this.btnRapport.MouseLeave += new System.EventHandler(this.btnRapport_MouseLeave);
            this.btnRapport.MouseHover += new System.EventHandler(this.btnRapport_MouseHover);
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetour.FlatAppearance.BorderSize = 2;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(12, 541);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(48, 39);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // picAnim
            // 
            this.picAnim.Image = ((System.Drawing.Image)(resources.GetObject("picAnim.Image")));
            this.picAnim.Location = new System.Drawing.Point(3, 17);
            this.picAnim.Name = "picAnim";
            this.picAnim.Size = new System.Drawing.Size(169, 119);
            this.picAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnim.TabIndex = 2;
            this.picAnim.TabStop = false;
            // 
            // btnModifierLiv
            // 
            this.btnModifierLiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierLiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModifierLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierLiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierLiv.Location = new System.Drawing.Point(16, 221);
            this.btnModifierLiv.Name = "btnModifierLiv";
            this.btnModifierLiv.Size = new System.Drawing.Size(138, 53);
            this.btnModifierLiv.TabIndex = 2;
            this.btnModifierLiv.Text = "Modifier";
            this.btnModifierLiv.UseVisualStyleBackColor = true;
            this.btnModifierLiv.Click += new System.EventHandler(this.btnModifierLiv_Click);
            this.btnModifierLiv.MouseLeave += new System.EventHandler(this.btnModifierLiv_MouseLeave);
            this.btnModifierLiv.MouseHover += new System.EventHandler(this.btnModifierLiv_MouseHover);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(16, 280);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(138, 59);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            this.btnSupprimer.MouseHover += new System.EventHandler(this.btnSupprimer_MouseHover);
            // 
            // btnAjouterLiv
            // 
            this.btnAjouterLiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterLiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAjouterLiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterLiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterLiv.Location = new System.Drawing.Point(16, 159);
            this.btnAjouterLiv.Name = "btnAjouterLiv";
            this.btnAjouterLiv.Size = new System.Drawing.Size(138, 56);
            this.btnAjouterLiv.TabIndex = 2;
            this.btnAjouterLiv.Text = "Ajouter";
            this.btnAjouterLiv.UseVisualStyleBackColor = true;
            this.btnAjouterLiv.Click += new System.EventHandler(this.btnAjouterLiv_Click);
            this.btnAjouterLiv.MouseLeave += new System.EventHandler(this.btnAjouterLiv_MouseLeave);
            this.btnAjouterLiv.MouseHover += new System.EventHandler(this.btnAjouterLiv_MouseHover);
            // 
            // pnlAvailable
            // 
            this.pnlAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.pnlAvailable.Controls.Add(this.pic1);
            this.pnlAvailable.Controls.Add(this.lblNbreDispo);
            this.pnlAvailable.Controls.Add(this.lblAvailable);
            this.pnlAvailable.Location = new System.Drawing.Point(362, 63);
            this.pnlAvailable.Name = "pnlAvailable";
            this.pnlAvailable.Size = new System.Drawing.Size(229, 205);
            this.pnlAvailable.TabIndex = 2;
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(27, 54);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(177, 114);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // lblNbreDispo
            // 
            this.lblNbreDispo.AutoSize = true;
            this.lblNbreDispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.lblNbreDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNbreDispo.Location = new System.Drawing.Point(172, 171);
            this.lblNbreDispo.Name = "lblNbreDispo";
            this.lblNbreDispo.Size = new System.Drawing.Size(32, 32);
            this.lblNbreDispo.TabIndex = 1;
            this.lblNbreDispo.Text = "0";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.lblAvailable.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAvailable.Location = new System.Drawing.Point(64, 22);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(91, 18);
            this.lblAvailable.TabIndex = 0;
            this.lblAvailable.Text = "Disponible";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.pic2);
            this.panel1.Controls.Add(this.lblNbreEmprunter);
            this.panel1.Controls.Add(this.lblEmprunter);
            this.panel1.Location = new System.Drawing.Point(869, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 205);
            this.panel1.TabIndex = 2;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(32, 54);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(177, 105);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // lblNbreEmprunter
            // 
            this.lblNbreEmprunter.AutoSize = true;
            this.lblNbreEmprunter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.lblNbreEmprunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNbreEmprunter.Location = new System.Drawing.Point(177, 162);
            this.lblNbreEmprunter.Name = "lblNbreEmprunter";
            this.lblNbreEmprunter.Size = new System.Drawing.Size(32, 32);
            this.lblNbreEmprunter.TabIndex = 1;
            this.lblNbreEmprunter.Text = "0";
            // 
            // lblEmprunter
            // 
            this.lblEmprunter.AutoSize = true;
            this.lblEmprunter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.lblEmprunter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblEmprunter.Location = new System.Drawing.Point(64, 22);
            this.lblEmprunter.Name = "lblEmprunter";
            this.lblEmprunter.Size = new System.Drawing.Size(95, 18);
            this.lblEmprunter.TabIndex = 0;
            this.lblEmprunter.Text = "Emprunter";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nom,
            this.Auteur,
            this.Status,
            this.NbrePages,
            this.AnneePublication});
            this.dataGridView1.Location = new System.Drawing.Point(181, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1172, 299);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // Code
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Code.DefaultCellStyle = dataGridViewCellStyle7;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Width = 65;
            // 
            // Nom
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Nom.DefaultCellStyle = dataGridViewCellStyle8;
            this.Nom.HeaderText = "Titre du livre";
            this.Nom.Name = "Nom";
            this.Nom.Width = 200;
            // 
            // Auteur
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.Auteur.DefaultCellStyle = dataGridViewCellStyle9;
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            this.Auteur.Width = 200;
            // 
            // Status
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.Status.DefaultCellStyle = dataGridViewCellStyle10;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 160;
            // 
            // NbrePages
            // 
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.NbrePages.DefaultCellStyle = dataGridViewCellStyle11;
            this.NbrePages.HeaderText = "NbrePages";
            this.NbrePages.Name = "NbrePages";
            this.NbrePages.Width = 120;
            // 
            // AnneePublication
            // 
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.AnneePublication.DefaultCellStyle = dataGridViewCellStyle12;
            this.AnneePublication.HeaderText = "AnneePublication";
            this.AnneePublication.Name = "AnneePublication";
            this.AnneePublication.Width = 120;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Disponible",
            "Indisponible"});
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Disponible",
            "Indisponible"});
            this.cmbStatus.Location = new System.Drawing.Point(1002, 334);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 36;
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQte.ForeColor = System.Drawing.Color.Black;
            this.lblQte.Location = new System.Drawing.Point(1151, 295);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(74, 17);
            this.lblQte.TabIndex = 31;
            this.lblQte.Text = "NbrePages";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(999, 295);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 17);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Status";
            // 
            // lblNomliv
            // 
            this.lblNomliv.AutoSize = true;
            this.lblNomliv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNomliv.ForeColor = System.Drawing.Color.Black;
            this.lblNomliv.Location = new System.Drawing.Point(565, 292);
            this.lblNomliv.Name = "lblNomliv";
            this.lblNomliv.Size = new System.Drawing.Size(88, 17);
            this.lblNomliv.TabIndex = 33;
            this.lblNomliv.Text = "Titre du Livre";
            // 
            // lblAPublication
            // 
            this.lblAPublication.AutoSize = true;
            this.lblAPublication.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAPublication.ForeColor = System.Drawing.Color.Black;
            this.lblAPublication.Location = new System.Drawing.Point(359, 295);
            this.lblAPublication.Name = "lblAPublication";
            this.lblAPublication.Size = new System.Drawing.Size(131, 17);
            this.lblAPublication.TabIndex = 34;
            this.lblAPublication.Text = "Annee de publication";
            // 
            // lblCodeliv
            // 
            this.lblCodeliv.AutoSize = true;
            this.lblCodeliv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblCodeliv.ForeColor = System.Drawing.Color.Black;
            this.lblCodeliv.Location = new System.Drawing.Point(181, 295);
            this.lblCodeliv.Name = "lblCodeliv";
            this.lblCodeliv.Size = new System.Drawing.Size(74, 17);
            this.lblCodeliv.TabIndex = 35;
            this.lblCodeliv.Text = "Code Livre";
            // 
            // txtNPages
            // 
            this.txtNPages.Location = new System.Drawing.Point(1154, 325);
            this.txtNPages.Multiline = true;
            this.txtNPages.Name = "txtNPages";
            this.txtNPages.Size = new System.Drawing.Size(90, 32);
            this.txtNPages.TabIndex = 28;
            this.txtNPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPages_KeyPress);
            // 
            // txtNomliv
            // 
            this.txtNomliv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomliv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomliv.Location = new System.Drawing.Point(568, 326);
            this.txtNomliv.Multiline = true;
            this.txtNomliv.Name = "txtNomliv";
            this.txtNomliv.Size = new System.Drawing.Size(209, 32);
            this.txtNomliv.TabIndex = 29;
            // 
            // txtCodeliv
            // 
            this.txtCodeliv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCodeliv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCodeliv.Location = new System.Drawing.Point(184, 329);
            this.txtCodeliv.Multiline = true;
            this.txtCodeliv.Name = "txtCodeliv";
            this.txtCodeliv.Size = new System.Drawing.Size(155, 31);
            this.txtCodeliv.TabIndex = 30;
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(794, 327);
            this.txtAuteur.Multiline = true;
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(170, 31);
            this.txtAuteur.TabIndex = 28;
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblAuteur.ForeColor = System.Drawing.Color.Black;
            this.lblAuteur.Location = new System.Drawing.Point(791, 292);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(49, 17);
            this.lblAuteur.TabIndex = 31;
            this.lblAuteur.Text = "Auteur";
            // 
            // txtAPublic
            // 
            this.txtAPublic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAPublic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAPublic.Location = new System.Drawing.Point(362, 330);
            this.txtAPublic.Multiline = true;
            this.txtAPublic.Name = "txtAPublic";
            this.txtAPublic.Size = new System.Drawing.Size(155, 31);
            this.txtAPublic.TabIndex = 30;
            this.txtAPublic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPublic_KeyPress);
            // 
            // Gestionnaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 640);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNomliv);
            this.Controls.Add(this.lblAPublication);
            this.Controls.Add(this.lblCodeliv);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.txtNPages);
            this.Controls.Add(this.txtNomliv);
            this.Controls.Add(this.txtAPublic);
            this.Controls.Add(this.txtCodeliv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAvailable);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.pnlTitre);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestionnaires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gestionnaires_Load);
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.pnlDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnim)).EndInit();
            this.pnlAvailable.ResumeLayout(false);
            this.pnlAvailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Label lblGestionnaire;
        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.PictureBox picAnim;
        private System.Windows.Forms.Button btnModifierLiv;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouterLiv;
        private System.Windows.Forms.Panel pnlAvailable;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label lblNbreDispo;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label lblNbreEmprunter;
        private System.Windows.Forms.Label lblEmprunter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNomliv;
        private System.Windows.Forms.Label lblAPublication;
        private System.Windows.Forms.Label lblCodeliv;
        private System.Windows.Forms.TextBox txtNPages;
        private System.Windows.Forms.TextBox txtNomliv;
        private System.Windows.Forms.TextBox txtCodeliv;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.TextBox txtAPublic;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbrePages;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnneePublication;
        private System.Windows.Forms.Button button1;
    }
}

