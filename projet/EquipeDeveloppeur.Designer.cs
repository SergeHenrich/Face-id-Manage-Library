namespace ProjetGroupe5
{
    partial class EquipeDeveloppeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipeDeveloppeur));
            this.pnlEQPDev = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitreAd = new System.Windows.Forms.Label();
            this.lblDescriptionEquipe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEQPDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEQPDev
            // 
            this.pnlEQPDev.BackColor = System.Drawing.Color.Teal;
            this.pnlEQPDev.Controls.Add(this.button1);
            this.pnlEQPDev.Controls.Add(this.lblTitreAd);
            this.pnlEQPDev.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEQPDev.Location = new System.Drawing.Point(0, 0);
            this.pnlEQPDev.Name = "pnlEQPDev";
            this.pnlEQPDev.Size = new System.Drawing.Size(833, 74);
            this.pnlEQPDev.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(776, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 46);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitreAd
            // 
            this.lblTitreAd.AutoSize = true;
            this.lblTitreAd.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAd.ForeColor = System.Drawing.Color.White;
            this.lblTitreAd.Location = new System.Drawing.Point(241, 19);
            this.lblTitreAd.Name = "lblTitreAd";
            this.lblTitreAd.Size = new System.Drawing.Size(295, 22);
            this.lblTitreAd.TabIndex = 2;
            this.lblTitreAd.Text = "EQUIPE DE DEVELOPPEURS";
            // 
            // lblDescriptionEquipe
            // 
            this.lblDescriptionEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescriptionEquipe.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblDescriptionEquipe.Location = new System.Drawing.Point(12, 86);
            this.lblDescriptionEquipe.Name = "lblDescriptionEquipe";
            this.lblDescriptionEquipe.Size = new System.Drawing.Size(807, 144);
            this.lblDescriptionEquipe.TabIndex = 1;
            this.lblDescriptionEquipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EquipeDeveloppeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescriptionEquipe);
            this.Controls.Add(this.pnlEQPDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipeDeveloppeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipeDeveloppeur";
            this.pnlEQPDev.ResumeLayout(false);
            this.pnlEQPDev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEQPDev;
        private System.Windows.Forms.Label lblTitreAd;
        private System.Windows.Forms.Label lblDescriptionEquipe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}