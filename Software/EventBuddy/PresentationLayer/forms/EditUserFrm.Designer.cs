namespace PresentationLayer.forms
{
    partial class EditUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserFrm));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAlertNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtNumberOfWarnings = new System.Windows.Forms.TextBox();
            this.btnOrganizerBox = new System.Windows.Forms.Button();
            this.btnModBox = new System.Windows.Forms.Button();
            this.btnOrganizer = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblName.Location = new System.Drawing.Point(26, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSurname.Location = new System.Drawing.Point(26, 128);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(76, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Prezime:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblUsername.Location = new System.Drawing.Point(26, 180);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblAlertNumber
            // 
            this.lblAlertNumber.AutoSize = true;
            this.lblAlertNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAlertNumber.Location = new System.Drawing.Point(26, 241);
            this.lblAlertNumber.Name = "lblAlertNumber";
            this.lblAlertNumber.Size = new System.Drawing.Size(132, 20);
            this.lblAlertNumber.TabIndex = 3;
            this.lblAlertNumber.Text = "Broj upozorenja:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtName.Location = new System.Drawing.Point(30, 99);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(296, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSurname.Location = new System.Drawing.Point(30, 151);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(296, 26);
            this.txtSurname.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtUsername.Location = new System.Drawing.Point(30, 203);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(296, 26);
            this.txtUsername.TabIndex = 6;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblRole.Location = new System.Drawing.Point(26, 286);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 20);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Uloge:";
            // 
            // txtNumberOfWarnings
            // 
            this.txtNumberOfWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNumberOfWarnings.Location = new System.Drawing.Point(272, 238);
            this.txtNumberOfWarnings.Name = "txtNumberOfWarnings";
            this.txtNumberOfWarnings.ReadOnly = true;
            this.txtNumberOfWarnings.Size = new System.Drawing.Size(54, 26);
            this.txtNumberOfWarnings.TabIndex = 8;
            // 
            // btnOrganizerBox
            // 
            this.btnOrganizerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnOrganizerBox.Location = new System.Drawing.Point(30, 309);
            this.btnOrganizerBox.Name = "btnOrganizerBox";
            this.btnOrganizerBox.Size = new System.Drawing.Size(138, 52);
            this.btnOrganizerBox.TabIndex = 9;
            this.btnOrganizerBox.Text = "Organizator";
            this.btnOrganizerBox.UseVisualStyleBackColor = true;
            // 
            // btnModBox
            // 
            this.btnModBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnModBox.Location = new System.Drawing.Point(188, 309);
            this.btnModBox.Name = "btnModBox";
            this.btnModBox.Size = new System.Drawing.Size(138, 52);
            this.btnModBox.TabIndex = 10;
            this.btnModBox.Text = "Moderator";
            this.btnModBox.UseVisualStyleBackColor = true;
            // 
            // btnOrganizer
            // 
            this.btnOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnOrganizer.Location = new System.Drawing.Point(30, 376);
            this.btnOrganizer.Name = "btnOrganizer";
            this.btnOrganizer.Size = new System.Drawing.Size(138, 28);
            this.btnOrganizer.TabIndex = 11;
            this.btnOrganizer.Text = "Dodaj ulogu";
            this.btnOrganizer.UseVisualStyleBackColor = true;
            this.btnOrganizer.Click += new System.EventHandler(this.btnOrganizer_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnMod.Location = new System.Drawing.Point(188, 376);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(138, 28);
            this.btnMod.TabIndex = 12;
            this.btnMod.Text = "Dodaj ulogu";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQuit.Location = new System.Drawing.Point(30, 432);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(138, 49);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Odustani";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSave.Location = new System.Drawing.Point(188, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 49);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 493);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnOrganizer);
            this.Controls.Add(this.btnModBox);
            this.Controls.Add(this.btnOrganizerBox);
            this.Controls.Add(this.txtNumberOfWarnings);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAlertNumber);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUserFrm";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmjena podataka korisnika";
            this.Load += new System.EventHandler(this.EditUserFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAlertNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtNumberOfWarnings;
        private System.Windows.Forms.Button btnOrganizerBox;
        private System.Windows.Forms.Button btnModBox;
        private System.Windows.Forms.Button btnOrganizer;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}