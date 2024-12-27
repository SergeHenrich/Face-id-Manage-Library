namespace ProjetGroupe5
{
    partial class Emprunt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emprunt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEmprunt = new System.Windows.Forms.DataGridView();
            this.IdEmprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEmprunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfoPrêt = new System.Windows.Forms.GroupBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.txtCodeLiv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomLiv = new System.Windows.Forms.Label();
            this.lblMatriculeUtil = new System.Windows.Forms.Label();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.btnVoirStock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmprunt)).BeginInit();
            this.gbInfoPrêt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblQuitter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPRUNT DE LIVRE ";
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuitter.ForeColor = System.Drawing.Color.White;
            this.lblQuitter.Location = new System.Drawing.Point(666, 21);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(23, 21);
            this.lblQuitter.TabIndex = 0;
            this.lblQuitter.Text = "X";
            this.lblQuitter.Click += new System.EventHandler(this.lblQuitter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.btnRetour);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 75);
            this.panel2.TabIndex = 1;
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(642, 16);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(47, 42);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(234, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMPRUNTER";
            // 
            // dtEmprunt
            // 
            this.dtEmprunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmprunt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmprunt,
            this.IdUsers,
            this.IdLiv,
            this.DateEmprunt,
            this.DateRetour});
            this.dtEmprunt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtEmprunt.Location = new System.Drawing.Point(0, 468);
            this.dtEmprunt.Name = "dtEmprunt";
            this.dtEmprunt.RowTemplate.Height = 24;
            this.dtEmprunt.Size = new System.Drawing.Size(701, 184);
            this.dtEmprunt.TabIndex = 2;
            // 
            // IdEmprunt
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.IdEmprunt.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdEmprunt.HeaderText = "IdEmprunt";
            this.IdEmprunt.Name = "IdEmprunt";
            this.IdEmprunt.Width = 120;
            // 
            // IdUsers
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.IdUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdUsers.HeaderText = "IdUsers";
            this.IdUsers.Name = "IdUsers";
            this.IdUsers.Width = 120;
            // 
            // IdLiv
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.IdLiv.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdLiv.HeaderText = "IdLiv";
            this.IdLiv.Name = "IdLiv";
            this.IdLiv.Width = 120;
            // 
            // DateEmprunt
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DateEmprunt.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateEmprunt.HeaderText = "DateEmprunt";
            this.DateEmprunt.Name = "DateEmprunt";
            this.DateEmprunt.Width = 120;
            // 
            // DateRetour
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DateRetour.DefaultCellStyle = dataGridViewCellStyle5;
            this.DateRetour.HeaderText = "DateRetour";
            this.DateRetour.Name = "DateRetour";
            this.DateRetour.Width = 120;
            // 
            // gbInfoPrêt
            // 
            this.gbInfoPrêt.Controls.Add(this.dtp2);
            this.gbInfoPrêt.Controls.Add(this.dtp1);
            this.gbInfoPrêt.Controls.Add(this.txtCodeLiv);
            this.gbInfoPrêt.Controls.Add(this.label3);
            this.gbInfoPrêt.Controls.Add(this.txtMat);
            this.gbInfoPrêt.Controls.Add(this.label5);
            this.gbInfoPrêt.Controls.Add(this.lblNomLiv);
            this.gbInfoPrêt.Controls.Add(this.lblMatriculeUtil);
            this.gbInfoPrêt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gbInfoPrêt.Location = new System.Drawing.Point(7, 143);
            this.gbInfoPrêt.Name = "gbInfoPrêt";
            this.gbInfoPrêt.Size = new System.Drawing.Size(412, 319);
            this.gbInfoPrêt.TabIndex = 3;
            this.gbInfoPrêt.TabStop = false;
            this.gbInfoPrêt.Text = "Infos Emprunt";
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(174, 260);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 25);
            this.dtp2.TabIndex = 32;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(174, 186);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 25);
            this.dtp1.TabIndex = 32;
            // 
            // txtCodeLiv
            // 
            this.txtCodeLiv.Location = new System.Drawing.Point(197, 112);
            this.txtCodeLiv.Multiline = true;
            this.txtCodeLiv.Name = "txtCodeLiv";
            this.txtCodeLiv.Size = new System.Drawing.Size(177, 30);
            this.txtCodeLiv.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(17, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "DateRetour :";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(197, 38);
            this.txtMat.Multiline = true;
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(177, 30);
            this.txtMat.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "DateEmprunt :";
            // 
            // lblNomLiv
            // 
            this.lblNomLiv.AutoSize = true;
            this.lblNomLiv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblNomLiv.Location = new System.Drawing.Point(31, 125);
            this.lblNomLiv.Name = "lblNomLiv";
            this.lblNomLiv.Size = new System.Drawing.Size(94, 17);
            this.lblNomLiv.TabIndex = 35;
            this.lblNomLiv.Text = "Code livre :  ";
            // 
            // lblMatriculeUtil
            // 
            this.lblMatriculeUtil.AutoSize = true;
            this.lblMatriculeUtil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblMatriculeUtil.Location = new System.Drawing.Point(12, 51);
            this.lblMatriculeUtil.Name = "lblMatriculeUtil";
            this.lblMatriculeUtil.Size = new System.Drawing.Size(108, 17);
            this.lblMatriculeUtil.TabIndex = 35;
            this.lblMatriculeUtil.Text = "Id Utilisateur : ";
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEmprunter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmprunter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprunter.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnEmprunter.Location = new System.Drawing.Point(557, 409);
            this.btnEmprunter.Name = "btnEmprunter";
            this.btnEmprunter.Size = new System.Drawing.Size(132, 46);
            this.btnEmprunter.TabIndex = 31;
            this.btnEmprunter.Text = "Emprunter";
            this.btnEmprunter.UseVisualStyleBackColor = false;
            this.btnEmprunter.Click += new System.EventHandler(this.btnEmprunter_Click);
            // 
            // btnVoirStock
            // 
            this.btnVoirStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVoirStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoirStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirStock.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnVoirStock.Location = new System.Drawing.Point(557, 348);
            this.btnVoirStock.Name = "btnVoirStock";
            this.btnVoirStock.Size = new System.Drawing.Size(132, 46);
            this.btnVoirStock.TabIndex = 32;
            this.btnVoirStock.Text = "Voir Stock";
            this.btnVoirStock.UseVisualStyleBackColor = false;
            this.btnVoirStock.Click += new System.EventHandler(this.btnVoirStock_Click);
            // 
            // Emprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 652);
            this.Controls.Add(this.btnVoirStock);
            this.Controls.Add(this.btnEmprunter);
            this.Controls.Add(this.gbInfoPrêt);
            this.Controls.Add(this.dtEmprunt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunt";
            this.Load += new System.EventHandler(this.Emprunt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmprunt)).EndInit();
            this.gbInfoPrêt.ResumeLayout(false);
            this.gbInfoPrêt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtEmprunt;
        private System.Windows.Forms.GroupBox gbInfoPrêt;
        private System.Windows.Forms.TextBox txtCodeLiv;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label lblNomLiv;
        private System.Windows.Forms.Label lblMatriculeUtil;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoirStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEmprunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRetour;
    }
}