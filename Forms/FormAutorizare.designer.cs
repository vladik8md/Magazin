namespace Magazin_UI.Forms
{
    partial class FormAutorizare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutorizare));
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
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
            this.PbLogo.TabIndex = 13;
            this.PbLogo.TabStop = false;
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.White;
            this.BtnEnter.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.BtnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.ForeColor = System.Drawing.Color.Black;
            this.BtnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEnter.Location = new System.Drawing.Point(237, 450);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(125, 50);
            this.BtnEnter.TabIndex = 2;
            this.BtnEnter.Text = "ENTER";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtLogin.Location = new System.Drawing.Point(200, 273);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(200, 35);
            this.TxtLogin.TabIndex = 0;
            this.TxtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLogin.TextChanged += new System.EventHandler(this.TxtLogin_TextChanged);
            // 
            // LblLogin
            // 
            this.LblLogin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(200, 230);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(200, 40);
            this.LblLogin.TabIndex = 46;
            this.LblLogin.Text = "LOGIN";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPassword
            // 
            this.LblPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(200, 330);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(200, 40);
            this.LblPassword.TabIndex = 48;
            this.LblPassword.Text = "PASSWORD";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPassword.Location = new System.Drawing.Point(200, 373);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(200, 35);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
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
            this.BtnExit.TabIndex = 49;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblText
            // 
            this.LblText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText.Location = new System.Drawing.Point(100, 541);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(400, 50);
            this.LblText.TabIndex = 103;
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAutorizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.PbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAutorizare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAutorizare";
            this.Load += new System.EventHandler(this.FormAutorizare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblText;
    }
}