namespace Magazin_UI.Forms
{
    partial class FormStergereProdus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStergereProdus));
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.LblProdus = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.TxtCategorie = new System.Windows.Forms.TextBox();
            this.TxtPret = new System.Windows.Forms.TextBox();
            this.LblPret = new System.Windows.Forms.Label();
            this.TxtDenumire = new System.Windows.Forms.TextBox();
            this.LblDenumire = new System.Windows.Forms.Label();
            this.LblCategorie = new System.Windows.Forms.Label();
            this.LblCod = new System.Windows.Forms.Label();
            this.BtnSterge = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMeniu = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.LblConfirmareText = new System.Windows.Forms.Label();
            this.BtnNu = new System.Windows.Forms.Button();
            this.BtnDa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(161, 50);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(278, 106);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 77;
            this.PbLogo.TabStop = false;
            // 
            // LblProdus
            // 
            this.LblProdus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdus.Location = new System.Drawing.Point(161, 200);
            this.LblProdus.Name = "LblProdus";
            this.LblProdus.Size = new System.Drawing.Size(278, 40);
            this.LblProdus.TabIndex = 76;
            this.LblProdus.Text = "ȘTERGERE PRODUS";
            this.LblProdus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.White;
            this.BtnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClear.BackgroundImage")));
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(445, 278);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(30, 30);
            this.BtnClear.TabIndex = 106;
            this.BtnClear.TabStop = false;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(445, 278);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(30, 30);
            this.BtnSearch.TabIndex = 97;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtCod
            // 
            this.TxtCod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtCod.Location = new System.Drawing.Point(250, 280);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(189, 25);
            this.TxtCod.TabIndex = 0;
            this.TxtCod.TextChanged += new System.EventHandler(this.TxtCod_TextChanged);
            // 
            // TxtCategorie
            // 
            this.TxtCategorie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtCategorie.Location = new System.Drawing.Point(250, 330);
            this.TxtCategorie.Name = "TxtCategorie";
            this.TxtCategorie.ReadOnly = true;
            this.TxtCategorie.Size = new System.Drawing.Size(189, 25);
            this.TxtCategorie.TabIndex = 98;
            this.TxtCategorie.TabStop = false;
            // 
            // TxtPret
            // 
            this.TxtPret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPret.Location = new System.Drawing.Point(250, 445);
            this.TxtPret.Name = "TxtPret";
            this.TxtPret.ReadOnly = true;
            this.TxtPret.Size = new System.Drawing.Size(189, 25);
            this.TxtPret.TabIndex = 100;
            this.TxtPret.TabStop = false;
            // 
            // LblPret
            // 
            this.LblPret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPret.Location = new System.Drawing.Point(161, 440);
            this.LblPret.Name = "LblPret";
            this.LblPret.Size = new System.Drawing.Size(80, 30);
            this.LblPret.TabIndex = 105;
            this.LblPret.Text = "Preț";
            this.LblPret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDenumire
            // 
            this.TxtDenumire.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtDenumire.Location = new System.Drawing.Point(250, 380);
            this.TxtDenumire.Multiline = true;
            this.TxtDenumire.Name = "TxtDenumire";
            this.TxtDenumire.ReadOnly = true;
            this.TxtDenumire.Size = new System.Drawing.Size(189, 40);
            this.TxtDenumire.TabIndex = 99;
            this.TxtDenumire.TabStop = false;
            // 
            // LblDenumire
            // 
            this.LblDenumire.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDenumire.Location = new System.Drawing.Point(161, 375);
            this.LblDenumire.Name = "LblDenumire";
            this.LblDenumire.Size = new System.Drawing.Size(80, 30);
            this.LblDenumire.TabIndex = 104;
            this.LblDenumire.Text = "Denumire";
            this.LblDenumire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCategorie
            // 
            this.LblCategorie.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCategorie.Location = new System.Drawing.Point(161, 325);
            this.LblCategorie.Name = "LblCategorie";
            this.LblCategorie.Size = new System.Drawing.Size(80, 30);
            this.LblCategorie.TabIndex = 103;
            this.LblCategorie.Text = "Categorie";
            this.LblCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCod
            // 
            this.LblCod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCod.Location = new System.Drawing.Point(161, 275);
            this.LblCod.Name = "LblCod";
            this.LblCod.Size = new System.Drawing.Size(80, 30);
            this.LblCod.TabIndex = 102;
            this.LblCod.Text = "Cod";
            this.LblCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSterge
            // 
            this.BtnSterge.BackColor = System.Drawing.Color.White;
            this.BtnSterge.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnSterge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnSterge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSterge.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSterge.Location = new System.Drawing.Point(245, 490);
            this.BtnSterge.Name = "BtnSterge";
            this.BtnSterge.Size = new System.Drawing.Size(110, 30);
            this.BtnSterge.TabIndex = 107;
            this.BtnSterge.TabStop = false;
            this.BtnSterge.Text = "ȘTERGE";
            this.BtnSterge.UseVisualStyleBackColor = false;
            this.BtnSterge.Click += new System.EventHandler(this.BtnSterge_Click);
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
            this.BtnBack.TabIndex = 111;
            this.BtnBack.TabStop = false;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            this.BtnFile.TabIndex = 110;
            this.BtnFile.TabStop = false;
            this.BtnFile.UseVisualStyleBackColor = false;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
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
            this.BtnExit.TabIndex = 109;
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
            this.BtnMeniu.TabIndex = 108;
            this.BtnMeniu.TabStop = false;
            this.BtnMeniu.UseVisualStyleBackColor = false;
            this.BtnMeniu.Click += new System.EventHandler(this.BtnMeniu_Click);
            // 
            // LblText
            // 
            this.LblText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(12, 541);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(400, 50);
            this.LblText.TabIndex = 112;
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblText.Click += new System.EventHandler(this.LblText_Click);
            // 
            // LblConfirmareText
            // 
            this.LblConfirmareText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmareText.Location = new System.Drawing.Point(12, 490);
            this.LblConfirmareText.Name = "LblConfirmareText";
            this.LblConfirmareText.Size = new System.Drawing.Size(219, 30);
            this.LblConfirmareText.TabIndex = 113;
            this.LblConfirmareText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnNu
            // 
            this.BtnNu.BackColor = System.Drawing.Color.White;
            this.BtnNu.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnNu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnNu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnNu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNu.Location = new System.Drawing.Point(245, 490);
            this.BtnNu.Name = "BtnNu";
            this.BtnNu.Size = new System.Drawing.Size(134, 30);
            this.BtnNu.TabIndex = 114;
            this.BtnNu.TabStop = false;
            this.BtnNu.Text = "NU";
            this.BtnNu.UseVisualStyleBackColor = false;
            this.BtnNu.Click += new System.EventHandler(this.BtnNu_Click);
            // 
            // BtnDa
            // 
            this.BtnDa.BackColor = System.Drawing.Color.White;
            this.BtnDa.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnDa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnDa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnDa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDa.Location = new System.Drawing.Point(385, 490);
            this.BtnDa.Name = "BtnDa";
            this.BtnDa.Size = new System.Drawing.Size(54, 30);
            this.BtnDa.TabIndex = 115;
            this.BtnDa.TabStop = false;
            this.BtnDa.Text = "DA";
            this.BtnDa.UseVisualStyleBackColor = false;
            this.BtnDa.Click += new System.EventHandler(this.BtnDa_Click);
            // 
            // FormStergereProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.BtnDa);
            this.Controls.Add(this.BtnNu);
            this.Controls.Add(this.LblConfirmareText);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMeniu);
            this.Controls.Add(this.BtnSterge);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtCod);
            this.Controls.Add(this.TxtCategorie);
            this.Controls.Add(this.TxtPret);
            this.Controls.Add(this.LblPret);
            this.Controls.Add(this.TxtDenumire);
            this.Controls.Add(this.LblDenumire);
            this.Controls.Add(this.LblCategorie);
            this.Controls.Add(this.LblCod);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.LblProdus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStergereProdus";
            this.Text = "FormStergereProdus";
            this.Load += new System.EventHandler(this.FormStergeProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label LblProdus;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.TextBox TxtCategorie;
        private System.Windows.Forms.TextBox TxtPret;
        private System.Windows.Forms.Label LblPret;
        private System.Windows.Forms.TextBox TxtDenumire;
        private System.Windows.Forms.Label LblDenumire;
        private System.Windows.Forms.Label LblCategorie;
        private System.Windows.Forms.Label LblCod;
        private System.Windows.Forms.Button BtnSterge;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMeniu;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Label LblConfirmareText;
        private System.Windows.Forms.Button BtnNu;
        private System.Windows.Forms.Button BtnDa;
    }
}