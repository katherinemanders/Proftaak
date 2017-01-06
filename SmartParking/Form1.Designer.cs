namespace SmartParking
{
    partial class Form1
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
            this.btnParkeerplaats = new System.Windows.Forms.Button();
            this.pictureBoxParkeerplaats = new System.Windows.Forms.PictureBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.tbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParkeerplaats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParkeerplaats
            // 
            this.btnParkeerplaats.Location = new System.Drawing.Point(24, 52);
            this.btnParkeerplaats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParkeerplaats.Name = "btnParkeerplaats";
            this.btnParkeerplaats.Size = new System.Drawing.Size(85, 49);
            this.btnParkeerplaats.TabIndex = 0;
            this.btnParkeerplaats.Text = "Parkeerplaats";
            this.btnParkeerplaats.UseVisualStyleBackColor = true;
            this.btnParkeerplaats.Click += new System.EventHandler(this.btnParkeerplaats_Click);
            // 
            // pictureBoxParkeerplaats
            // 
            this.pictureBoxParkeerplaats.Location = new System.Drawing.Point(212, 52);
            this.pictureBoxParkeerplaats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxParkeerplaats.Name = "pictureBoxParkeerplaats";
            this.pictureBoxParkeerplaats.Size = new System.Drawing.Size(300, 244);
            this.pictureBoxParkeerplaats.TabIndex = 1;
            this.pictureBoxParkeerplaats.TabStop = false;
            this.pictureBoxParkeerplaats.Visible = false;
            this.pictureBoxParkeerplaats.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxParkeerplaats_Paint);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(25, 199);
            this.btnInloggen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(85, 46);
            this.btnInloggen.TabIndex = 2;
            this.btnInloggen.Text = "Log in";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // tbGebruikersnaam
            // 
            this.tbGebruikersnaam.Location = new System.Drawing.Point(94, 130);
            this.tbGebruikersnaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGebruikersnaam.Name = "tbGebruikersnaam";
            this.tbGebruikersnaam.Size = new System.Drawing.Size(95, 20);
            this.tbGebruikersnaam.TabIndex = 3;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(94, 153);
            this.tbWachtwoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(95, 20);
            this.tbWachtwoord.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(22, 134);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(22, 155);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 300);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(67, 27);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(120, 300);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(67, 27);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 347);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbGebruikersnaam);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.pictureBoxParkeerplaats);
            this.Controls.Add(this.btnParkeerplaats);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParkeerplaats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParkeerplaats;
        private System.Windows.Forms.PictureBox pictureBoxParkeerplaats;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.TextBox tbGebruikersnaam;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

