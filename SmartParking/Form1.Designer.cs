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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParkeerplaats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParkeerplaats
            // 
            this.btnParkeerplaats.Location = new System.Drawing.Point(24, 52);
            this.btnParkeerplaats.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBoxParkeerplaats.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnInloggen.Margin = new System.Windows.Forms.Padding(2);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(85, 46);
            this.btnInloggen.TabIndex = 2;
            this.btnInloggen.Text = "Log in";
            this.btnInloggen.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(94, 130);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(95, 20);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(94, 153);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(95, 20);
            this.tbPassword.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 347);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.pictureBoxParkeerplaats);
            this.Controls.Add(this.btnParkeerplaats);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
    }
}

