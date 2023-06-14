namespace Magazin_UI.Forms
{
    partial class FormAdaugareProdus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdaugareProdus));
            this.BtnAdauga = new System.Windows.Forms.Button();
            this.TxtPret = new System.Windows.Forms.TextBox();
            this.LblPret = new System.Windows.Forms.Label();
            this.TxtDenumire = new System.Windows.Forms.TextBox();
            this.LblDenumire = new System.Windows.Forms.Label();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.LblProdus = new System.Windows.Forms.Label();
            this.CbCategorie = new System.Windows.Forms.ComboBox();
            this.LblText = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMeniu = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnFile = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnCategoriiFile = new System.Windows.Forms.Button();
            this.LblCategorieText = new System.Windows.Forms.Label();
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
            this.BtnAdauga.Location = new System.Drawing.Point(245, 440);
            this.BtnAdauga.Name = "BtnAdauga";
            this.BtnAdauga.Size = new System.Drawing.Size(110, 30);
            this.BtnAdauga.TabIndex = 3;
            this.BtnAdauga.Text = "ADAUGĂ";
            this.BtnAdauga.UseVisualStyleBackColor = false;
            this.BtnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // TxtPret
            // 
            this.TxtPret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPret.Location = new System.Drawing.Point(250, 395);
            this.TxtPret.Name = "TxtPret";
            this.TxtPret.Size = new System.Drawing.Size(189, 25);
            this.TxtPret.TabIndex = 2;
            // 
            // LblPret
            // 
            this.LblPret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPret.Location = new System.Drawing.Point(161, 390);
            this.LblPret.Name = "LblPret";
            this.LblPret.Size = new System.Drawing.Size(80, 30);
            this.LblPret.TabIndex = 25;
            this.LblPret.Text = "Preț";
            this.LblPret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDenumire
            // 
            this.TxtDenumire.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtDenumire.Location = new System.Drawing.Point(250, 330);
            this.TxtDenumire.Multiline = true;
            this.TxtDenumire.Name = "TxtDenumire";
            this.TxtDenumire.Size = new System.Drawing.Size(189, 40);
            this.TxtDenumire.TabIndex = 1;
            // 
            // LblDenumire
            // 
            this.LblDenumire.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDenumire.Location = new System.Drawing.Point(161, 325);
            this.LblDenumire.Name = "LblDenumire";
            this.LblDenumire.Size = new System.Drawing.Size(80, 30);
            this.LblDenumire.TabIndex = 23;
            this.LblDenumire.Text = "Denumire";
            this.LblDenumire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCategorie
            // 
            this.LblCategorie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCategorie.Location = new System.Drawing.Point(161, 275);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(80, 30);
            this.LblCategorie.TabIndex = 21;
            this.LblCategorie.Text = "Categorie";
            this.LblCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblProdus
            // 
            this.LblProdus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdus.Location = new System.Drawing.Point(161, 200);
            this.LblProdus.Name = "LblProdus";
            this.LblProdus.Size = new System.Drawing.Size(278, 40);
            this.LblProdus.TabIndex = 18;
            this.LblProdus.Text = "ADĂUGARE PRODUS";
            this.LblProdus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbCategorie
            // 
            this.CbCategorie.BackColor = System.Drawing.Color.White;
            this.CbCategorie.DropDownHeight = 200;
            this.CbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbCategorie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbCategorie.FormattingEnabled = true;
            this.CbCategorie.IntegralHeight = false;
            this.CbCategorie.Location = new System.Drawing.Point(250, 280);
            this.CbCategorie.Name = "CbCategorie";
            this.CbCategorie.Size = new System.Drawing.Size(189, 26);
            this.CbCategorie.Sorted = true;
            this.CbCategorie.TabIndex = 0;
            // 
            // LblText
            // 
            this.LblText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(12, 541);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(400, 50);
            this.LblText.TabIndex = 31;
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblText.Click += new System.EventHandler(this.LblText_Click);
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
            this.BtnExit.TabIndex = 33;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.BtnMeniu.TabIndex = 32;
            this.BtnMeniu.TabStop = false;
            this.BtnMeniu.UseVisualStyleBackColor = false;
            this.BtnMeniu.Click += new System.EventHandler(this.BtnMeniu_Click);
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(161, 50);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(278, 106);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 34;
            this.PbLogo.TabStop = false;
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
            this.BtnFile.TabIndex = 50;
            this.BtnFile.TabStop = false;
            this.BtnFile.UseVisualStyleBackColor = false;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.BackColor = System.Drawing.Color.White;
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("PT Utah Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBack.Location = new System.Drawing.Point(482, 538);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(50, 50);
            this.BtnBack.TabIndex = 51;
            this.BtnBack.TabStop = false;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnCategoriiFile
            // 
            this.BtnCategoriiFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCategoriiFile.BackColor = System.Drawing.Color.White;
            this.BtnCategoriiFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCategoriiFile.BackgroundImage")));
            this.BtnCategoriiFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCategoriiFile.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnCategoriiFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnCategoriiFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnCategoriiFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoriiFile.Font = new System.Drawing.Font("PT Utah Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategoriiFile.ForeColor = System.Drawing.Color.White;
            this.BtnCategoriiFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCategoriiFile.Location = new System.Drawing.Point(445, 278);
            this.BtnCategoriiFile.Name = "BtnCategoriiFile";
            this.BtnCategoriiFile.Size = new System.Drawing.Size(30, 30);
            this.BtnCategoriiFile.TabIndex = 52;
            this.BtnCategoriiFile.TabStop = false;
            this.BtnCategoriiFile.UseVisualStyleBackColor = false;
            this.BtnCategoriiFile.Click += new System.EventHandler(this.BtnCategoriiFile_Click);
            // 
            // LblCategorieText
            // 
            this.LblCategorieText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategorieText.Location = new System.Drawing.Point(12, 491);
            this.LblCategorieText.Name = "LblCategorieText";
            this.LblCategorieText.Size = new System.Drawing.Size(400, 50);
            this.LblCategorieText.TabIndex = 53;
            this.LblCategorieText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCategorieText.Click += new System.EventHandler(this.LblCategorieText_Click);
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
            this.BtnCalc.Location = new System.Drawing.Point(445, 392);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(30, 30);
            this.BtnCalc.TabIndex = 54;
            this.BtnCalc.TabStop = false;
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // FormAdaugareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblCategorieText);
            this.Controls.Add(this.BtnCategoriiFile);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMeniu);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.CbCategorie);
            this.Controls.Add(this.BtnAdauga);
            this.Controls.Add(this.TxtPret);
            this.Controls.Add(this.LblPret);
            this.Controls.Add(this.TxtDenumire);
            this.Controls.Add(this.LblDenumire);
            this.Controls.Add(this.LblCategorie);
            this.Controls.Add(this.LblProdus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdaugareProdus";
            this.Text = "FormCitireProdus";
            this.Load += new System.EventHandler(this.FormAdaugareProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdauga;
        private System.Windows.Forms.TextBox TxtPret;
        private System.Windows.Forms.Label LblPret;
        private System.Windows.Forms.TextBox TxtDenumire;
        private System.Windows.Forms.Label LblDenumire;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.Label LblProdus;
        private System.Windows.Forms.ComboBox CbCategorie;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMeniu;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnCategoriiFile;
        private System.Windows.Forms.Label LblCategorieText;
        private System.Windows.Forms.Button BtnCalc;
    }
}