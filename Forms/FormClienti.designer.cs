namespace Magazin_UI.Forms
{
    partial class FormClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienti));
            this.LblClienti = new System.Windows.Forms.Label();
            this.BtnAfisare = new System.Windows.Forms.Button();
            this.BtnAdaugare = new System.Windows.Forms.Button();
            this.BtnEditare = new System.Windows.Forms.Button();
            this.BtnCautare = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnMeniu = new System.Windows.Forms.Button();
            this.BtnStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClienti
            // 
            this.LblClienti.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblClienti.Location = new System.Drawing.Point(161, 200);
            this.LblClienti.Name = "LblClienti";
            this.LblClienti.Size = new System.Drawing.Size(278, 40);
            this.LblClienti.TabIndex = 3;
            this.LblClienti.Text = "CLIENȚI";
            this.LblClienti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAfisare
            // 
            this.BtnAfisare.BackColor = System.Drawing.Color.White;
            this.BtnAfisare.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnAfisare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnAfisare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnAfisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAfisare.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAfisare.Location = new System.Drawing.Point(190, 325);
            this.BtnAfisare.Name = "BtnAfisare";
            this.BtnAfisare.Size = new System.Drawing.Size(220, 40);
            this.BtnAfisare.TabIndex = 1;
            this.BtnAfisare.Text = "AFIȘARE CLIENȚI";
            this.BtnAfisare.UseVisualStyleBackColor = false;
            this.BtnAfisare.Click += new System.EventHandler(this.BtnAfisare_Click);
            // 
            // BtnAdaugare
            // 
            this.BtnAdaugare.BackColor = System.Drawing.Color.White;
            this.BtnAdaugare.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnAdaugare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnAdaugare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnAdaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdaugare.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdaugare.Location = new System.Drawing.Point(190, 275);
            this.BtnAdaugare.Name = "BtnAdaugare";
            this.BtnAdaugare.Size = new System.Drawing.Size(220, 40);
            this.BtnAdaugare.TabIndex = 0;
            this.BtnAdaugare.Text = "ADĂUGARE CLIENT";
            this.BtnAdaugare.UseVisualStyleBackColor = false;
            this.BtnAdaugare.Click += new System.EventHandler(this.BtnAdaugare_Click);
            // 
            // BtnEditare
            // 
            this.BtnEditare.BackColor = System.Drawing.Color.White;
            this.BtnEditare.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnEditare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnEditare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditare.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditare.Location = new System.Drawing.Point(190, 425);
            this.BtnEditare.Name = "BtnEditare";
            this.BtnEditare.Size = new System.Drawing.Size(220, 40);
            this.BtnEditare.TabIndex = 3;
            this.BtnEditare.Text = "EDITARE CLIENT";
            this.BtnEditare.UseVisualStyleBackColor = false;
            this.BtnEditare.Click += new System.EventHandler(this.BtnEditare_Click);
            // 
            // BtnCautare
            // 
            this.BtnCautare.BackColor = System.Drawing.Color.White;
            this.BtnCautare.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnCautare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnCautare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnCautare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCautare.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCautare.Location = new System.Drawing.Point(190, 375);
            this.BtnCautare.Name = "BtnCautare";
            this.BtnCautare.Size = new System.Drawing.Size(220, 40);
            this.BtnCautare.TabIndex = 2;
            this.BtnCautare.Text = "CĂUTARE CLIENT";
            this.BtnCautare.UseVisualStyleBackColor = false;
            this.BtnCautare.Click += new System.EventHandler(this.BtnCautare_Click);
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(161, 50);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(278, 106);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 14;
            this.PbLogo.TabStop = false;
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
            this.BtnExit.TabIndex = 18;
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
            this.BtnMeniu.TabIndex = 20;
            this.BtnMeniu.TabStop = false;
            this.BtnMeniu.UseVisualStyleBackColor = false;
            this.BtnMeniu.Click += new System.EventHandler(this.BtnMeniu_Click);
            // 
            // BtnStergere
            // 
            this.BtnStergere.BackColor = System.Drawing.Color.White;
            this.BtnStergere.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnStergere.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnStergere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStergere.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStergere.Location = new System.Drawing.Point(190, 475);
            this.BtnStergere.Name = "BtnStergere";
            this.BtnStergere.Size = new System.Drawing.Size(220, 40);
            this.BtnStergere.TabIndex = 4;
            this.BtnStergere.Text = "ȘTERGERE CLIENT";
            this.BtnStergere.UseVisualStyleBackColor = false;
            this.BtnStergere.Click += new System.EventHandler(this.BtnStergere_Click);
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.BtnStergere);
            this.Controls.Add(this.BtnMeniu);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.BtnCautare);
            this.Controls.Add(this.BtnEditare);
            this.Controls.Add(this.BtnAfisare);
            this.Controls.Add(this.BtnAdaugare);
            this.Controls.Add(this.LblClienti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClienti";
            this.Text = "FormClienti";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblClienti;
        private System.Windows.Forms.Button BtnAfisare;
        private System.Windows.Forms.Button BtnAdaugare;
        private System.Windows.Forms.Button BtnEditare;
        private System.Windows.Forms.Button BtnCautare;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnMeniu;
        private System.Windows.Forms.Button BtnStergere;
    }
}