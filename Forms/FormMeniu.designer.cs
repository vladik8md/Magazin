namespace Magazin_UI.Forms
{
    partial class FormMeniu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeniu));
            this.BtnClienti = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnProduse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClienti
            // 
            this.BtnClienti.BackColor = System.Drawing.Color.White;
            this.BtnClienti.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnClienti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnClienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClienti.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClienti.ForeColor = System.Drawing.Color.Black;
            this.BtnClienti.Image = ((System.Drawing.Image)(resources.GetObject("BtnClienti.Image")));
            this.BtnClienti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClienti.Location = new System.Drawing.Point(200, 300);
            this.BtnClienti.Name = "BtnClienti";
            this.BtnClienti.Size = new System.Drawing.Size(200, 66);
            this.BtnClienti.TabIndex = 1;
            this.BtnClienti.Text = "       CLIENȚI";
            this.BtnClienti.UseVisualStyleBackColor = false;
            this.BtnClienti.Click += new System.EventHandler(this.BtnClienti_Click);
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
            this.BtnExit.TabIndex = 11;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(161, 50);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(278, 106);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 12;
            this.PbLogo.TabStop = false;
            // 
            // BtnProduse
            // 
            this.BtnProduse.BackColor = System.Drawing.Color.White;
            this.BtnProduse.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnProduse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnProduse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnProduse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduse.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnProduse.ForeColor = System.Drawing.Color.Black;
            this.BtnProduse.Image = ((System.Drawing.Image)(resources.GetObject("BtnProduse.Image")));
            this.BtnProduse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduse.Location = new System.Drawing.Point(200, 200);
            this.BtnProduse.Name = "BtnProduse";
            this.BtnProduse.Size = new System.Drawing.Size(200, 66);
            this.BtnProduse.TabIndex = 0;
            this.BtnProduse.Text = "              PRODUSE  ";
            this.BtnProduse.UseVisualStyleBackColor = false;
            this.BtnProduse.Click += new System.EventHandler(this.BtnProduse_Click);
            // 
            // FormMeniu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.BtnClienti);
            this.Controls.Add(this.BtnProduse);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.PbLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMeniu";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClienti;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button BtnProduse;
    }
}

