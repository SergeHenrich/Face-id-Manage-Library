namespace ProjetGroupe5
{
    partial class StockLivres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockLivres));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuitter = new System.Windows.Forms.Label();
            this.lblTitreStock = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgLivres = new System.Windows.Forms.DataGridView();
            this.LivresID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnneePublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.lblQuitter);
            this.panel1.Controls.Add(this.lblTitreStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblQuitter
            // 
            this.lblQuitter.AutoSize = true;
            this.lblQuitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuitter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblQuitter.ForeColor = System.Drawing.Color.White;
            this.lblQuitter.Location = new System.Drawing.Point(1195, 22);
            this.lblQuitter.Name = "lblQuitter";
            this.lblQuitter.Size = new System.Drawing.Size(23, 21);
            this.lblQuitter.TabIndex = 3;
            this.lblQuitter.Text = "X";
            // 
            // lblTitreStock
            // 
            this.lblTitreStock.AutoSize = true;
            this.lblTitreStock.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreStock.ForeColor = System.Drawing.Color.White;
            this.lblTitreStock.Location = new System.Drawing.Point(612, 22);
            this.lblTitreStock.Name = "lblTitreStock";
            this.lblTitreStock.Size = new System.Drawing.Size(149, 18);
            this.lblTitreStock.TabIndex = 2;
            this.lblTitreStock.Text = "STOCK DE LIVRES";
            // 
            // btnRetour
            // 
            this.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(0, 60);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(49, 44);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgLivres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 430);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur les livres";
            // 
            // dvgLivres
            // 
            this.dvgLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LivresID,
            this.Code,
            this.Nom,
            this.Auteur,
            this.Disponibilité,
            this.NombrePages,
            this.AnneePublication});
            this.dvgLivres.Location = new System.Drawing.Point(9, 39);
            this.dvgLivres.Name = "dvgLivres";
            this.dvgLivres.RowTemplate.Height = 24;
            this.dvgLivres.Size = new System.Drawing.Size(1148, 391);
            this.dvgLivres.TabIndex = 4;
            // 
            // LivresID
            // 
            this.LivresID.HeaderText = "LivresID";
            this.LivresID.Name = "LivresID";
            this.LivresID.Width = 80;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Width = 130;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 240;
            // 
            // Auteur
            // 
            this.Auteur.HeaderText = "Auteur";
            this.Auteur.Name = "Auteur";
            this.Auteur.Width = 160;
            // 
            // Disponibilité
            // 
            this.Disponibilité.HeaderText = "Disponibilité";
            this.Disponibilité.Name = "Disponibilité";
            this.Disponibilité.Width = 160;
            // 
            // NombrePages
            // 
            this.NombrePages.HeaderText = "NombrePages";
            this.NombrePages.Name = "NombrePages";
            this.NombrePages.Width = 160;
            // 
            // AnneePublication
            // 
            this.AnneePublication.HeaderText = "AnneePublication";
            this.AnneePublication.Name = "AnneePublication";
            this.AnneePublication.Width = 160;
            // 
            // StockLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 540);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockLivres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.StockLivres_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLivres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitreStock;
        private System.Windows.Forms.Label lblQuitter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgLivres;
        private System.Windows.Forms.DataGridViewTextBoxColumn LivresID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilité;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePages;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnneePublication;
    }
}