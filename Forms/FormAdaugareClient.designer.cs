namespace Magazin_UI.Forms
{
    partial class FormAdaugareClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugareClient));
            this.BtnAdauga = new System.Windows.Forms.Button();
            this.TxtPrenume = new System.Windows.Forms.TextBox();
            this.LblPrenume = new System.Windows.Forms.Label();
            this.TxtNume = new System.Windows.Forms.TextBox();
            this.LblNume = new System.Windows.Forms.Label();
            this.LblCodPersonal = new System.Windows.Forms.Label();
            this.LblClient = new System.Windows.Forms.Label();
            this.TxtCodPersonal = new System.Windows.Forms.TextBox();
            this.TxtSuma = new System.Windows.Forms.TextBox();
            this.LblSuma = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnMeniu = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdauga
            // 
            this.BtnAdauga.BackColor = System.Drawing.Color.White;
            this.BtnAdauga.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnAdauga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnAdauga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdauga.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdauga.Location = new System.Drawing.Point(245, 475);
            this.BtnAdauga.Name = "BtnAdauga";
            this.BtnAdauga.Size = new System.Drawing.Size(110, 30);
            this.BtnAdauga.TabIndex = 4;
            this.BtnAdauga.Text = "ADAUGĂ";
            this.BtnAdauga.UseVisualStyleBackColor = false;
            this.BtnAdauga.Click += new System.EventHandler(this.BtnAdaugaClient_Click);
            // 
            // TxtPrenume
            // 
            this.TxtPrenume.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPrenume.Location = new System.Drawing.Point(277, 380);
            this.TxtPrenume.Name = "TxtPrenume";
            this.TxtPrenume.Size = new System.Drawing.Size(162, 25);
            this.TxtPrenume.TabIndex = 2;
            // 
            // LblPrenume
            // 
            this.LblPrenume.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPrenume.Location = new System.Drawing.Point(161, 375);
            this.LblPrenume.Name = "LblPrenume";
            this.LblPrenume.Size = new System.Drawing.Size(110, 30);
            this.LblPrenume.TabIndex = 35;
            this.LblPrenume.Text = "Prenume";
            this.LblPrenume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNume
            // 
            this.TxtNume.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtNume.Location = new System.Drawing.Point(277, 330);
            this.TxtNume.Name = "TxtNume";
            this.TxtNume.Size = new System.Drawing.Size(162, 25);
            this.TxtNume.TabIndex = 1;
            // 
            // LblNume
            // 
            this.LblNume.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNume.Location = new System.Drawing.Point(161, 325);
            this.LblNume.Name = "LblNume";
            this.LblNume.Size = new System.Drawing.Size(110, 30);
            this.LblNume.TabIndex = 33;
            this.LblNume.Text = "Nume";
            this.LblNume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCodPersonal
            // 
            this.LblCodPersonal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCodPersonal.Location = new System.Drawing.Point(161, 275);
            this.LblCodPersonal.Name = "LblCodPersonal";
            this.LblCodPersonal.Size = new System.Drawing.Size(110, 30);
            this.LblCodPersonal.TabIndex = 32;
            this.LblCodPersonal.Text = "Cod personal";
            this.LblCodPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblClient
            // 
            this.LblClient.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblClient.Location = new System.Drawing.Point(161, 200);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(278, 40);
            this.LblClient.TabIndex = 31;
            this.LblClient.Text = "ADĂUGARE CLIENT";
            this.LblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodPersonal
            // 
            this.TxtCodPersonal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtCodPersonal.Location = new System.Drawing.Point(277, 280);
            this.TxtCodPersonal.Name = "TxtCodPersonal";
            this.TxtCodPersonal.Size = new System.Drawing.Size(162, 25);
            this.TxtCodPersonal.TabIndex = 0;
            // 
            // TxtSuma
            // 
            this.TxtSuma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSuma.Location = new System.Drawing.Point(277, 430);
            this.TxtSuma.Name = "TxtSuma";
            this.TxtSuma.Size = new System.Drawing.Size(162, 25);
            this.TxtSuma.TabIndex = 3;
            // 
            // LblSuma
            // 
            this.LblSuma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSuma.Location = new System.Drawing.Point(149, 425);
            this.LblSuma.Name = "LblSuma";
            this.LblSuma.Size = new System.Drawing.Size(122, 30);
            this.LblSuma.TabIndex = 41;
            this.LblSuma.Text = "Suma cheltuită";
            this.LblSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblText
            // 
            this.LblText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblText.Location = new System.Drawing.Point(12, 541);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(400, 50);
            this.LblText.TabIndex = 43;
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblText.Click += new System.EventHandler(this.LblText_Click);
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(161, 50);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(278, 106);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 44;
            this.PbLogo.TabStop = false;
            // 
            // BtnMeniu
            // 
            this.BtnMeniu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMeniu.BackColor = System.Drawing.Color.White;
            this.BtnMeniu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMeniu.BackgroundImage")));
            this.BtnMeniu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMeniu.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnMeniu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnMeniu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnMeniu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMeniu.Font = new System.Drawing.Font("PT Utah Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMeniu.ForeColor = System.Drawing.Color.White;
            this.BtnMeniu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMeniu.Location = new System.Drawing.Point(538, 538);
            this.BtnMeniu.Name = "BtnMeniu";
            this.BtnMeniu.Size = new System.Drawing.Size(50, 50);
            this.BtnMeniu.TabIndex = 46;
            this.BtnMeniu.TabStop = false;
            this.BtnMeniu.UseVisualStyleBackColor = false;
            this.BtnMeniu.Click += new System.EventHandler(this.BtnMeniu_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.White;
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(482, 538);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(50, 50);
            this.BtnBack.TabIndex = 45;
            this.BtnBack.TabStop = false;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("PT Utah Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(558, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(30, 30);
            this.BtnExit.TabIndex = 48;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnFile
            // 
            this.BtnFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFile.BackColor = System.Drawing.Color.White;
            this.BtnFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFile.BackgroundImage")));
            this.BtnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFile.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFile.Font = new System.Drawing.Font("PT Utah Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFile.ForeColor = System.Drawing.Color.White;
            this.BtnFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFile.Location = new System.Drawing.Point(538, 482);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(50, 50);
            this.BtnFile.TabIndex = 49;
            this.BtnFile.TabStop = false;
            this.BtnFile.UseVisualStyleBackColor = false;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCalc.BackColor = System.Drawing.Color.White;
            this.BtnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalc.BackgroundImage")));
            this.BtnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCalc.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalc.Font = new System.Drawing.Font("PT Utah Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.ForeColor = System.Drawing.Color.White;
            this.BtnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCalc.Location = new System.Drawing.Point(445, 427);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(30, 30);
            this.BtnCalc.TabIndex = 50;
            this.BtnCalc.TabStop = false;
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // FormAdaugareClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMeniu);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.TxtSuma);
            this.Controls.Add(this.LblSuma);
            this.Controls.Add(this.TxtCodPersonal);
            this.Controls.Add(this.BtnAdauga);
            this.Controls.Add(this.TxtPrenume);
            this.Controls.Add(this.LblPrenume);
            this.Controls.Add(this.TxtNume);
            this.Controls.Add(this.LblNume);
            this.Controls.Add(this.LblCodPersonal);
            this.Controls.Add(this.LblClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdaugareClient";
            this.Text = "FormAdaugareClient";
            this.Load += new System.EventHandler(this.FormAdaugareClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAdauga;
        private System.Windows.Forms.TextBox TxtPrenume;
        private System.Windows.Forms.Label LblPrenume;
        private System.Windows.Forms.TextBox TxtNume;
        private System.Windows.Forms.Label LblNume;
        private System.Windows.Forms.Label LblCodPersonal;
        private System.Windows.Forms.Label LblClient;
        private System.Windows.Forms.TextBox TxtCodPersonal;
        private System.Windows.Forms.TextBox TxtSuma;
        private System.Windows.Forms.Label LblSuma;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button BtnMeniu;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button BtnCalc;
    }
}