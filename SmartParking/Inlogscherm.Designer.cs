namespace SmartParking
{
    partial class Inlogscherm
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
            this.lblWelkom = new System.Windows.Forms.Label();
            this.lblVoorkeur = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Location = new System.Drawing.Point(33, 42);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(35, 13);
            this.lblWelkom.TabIndex = 0;
            this.lblWelkom.Text = "label1";
            // 
            // lblVoorkeur
            // 
            this.lblVoorkeur.AutoSize = true;
            this.lblVoorkeur.Location = new System.Drawing.Point(36, 117);
            this.lblVoorkeur.Name = "lblVoorkeur";
            this.lblVoorkeur.Size = new System.Drawing.Size(62, 13);
            this.lblVoorkeur.TabIndex = 1;
            this.lblVoorkeur.Text = "Voorkeuren";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(39, 145);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(138, 109);
            this.checkedListBox1.TabIndex = 2;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(494, 384);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 3;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(438, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 25);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "label1";
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 442);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblVoorkeur);
            this.Controls.Add(this.lblWelkom);
            this.Name = "Inlogscherm";
            this.Text = "Inlogscherm";
            this.Load += new System.EventHandler(this.Inlogscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.Label lblVoorkeur;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Label lblStatus;
    }
}