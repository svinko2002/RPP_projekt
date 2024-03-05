namespace PresentationLayer
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTheme = new System.Windows.Forms.Label();
            this.msChangeTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.lblMyProfile = new MaterialSkin.Controls.MaterialLabel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(12, 75);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbLanguage.TabIndex = 0;
            this.cbLanguage.DropDownClosed += new System.EventHandler(this.cbLanguage_DropDownClosed);
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(273, 182);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.ReadOnly = true;
            this.txtKorime.Size = new System.Drawing.Size(222, 20);
            this.txtKorime.TabIndex = 2;
            this.txtKorime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(273, 232);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(222, 20);
            this.txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(273, 268);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(222, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Location = new System.Drawing.Point(273, 305);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(222, 20);
            this.txtNewPassword2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTheme.Location = new System.Drawing.Point(557, 77);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(121, 20);
            this.lblTheme.TabIndex = 11;
            this.lblTheme.Text = "Promijeni temu: ";
            // 
            // msChangeTheme
            // 
            this.msChangeTheme.AutoSize = true;
            this.msChangeTheme.Depth = 0;
            this.msChangeTheme.Location = new System.Drawing.Point(706, 71);
            this.msChangeTheme.Margin = new System.Windows.Forms.Padding(0);
            this.msChangeTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.msChangeTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.msChangeTheme.Name = "msChangeTheme";
            this.msChangeTheme.Ripple = true;
            this.msChangeTheme.Size = new System.Drawing.Size(58, 37);
            this.msChangeTheme.TabIndex = 12;
            this.msChangeTheme.UseVisualStyleBackColor = true;
            this.msChangeTheme.CheckedChanged += new System.EventHandler(this.msChangeTheme_CheckedChanged);
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.Depth = 0;
            this.lblMyProfile.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMyProfile.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblMyProfile.Location = new System.Drawing.Point(288, 109);
            this.lblMyProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(207, 58);
            this.lblMyProfile.TabIndex = 13;
            this.lblMyProfile.Text = "Moj Profil";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMyProfile);
            this.Controls.Add(this.msChangeTheme);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.cbLanguage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profil";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfil";
            this.Load += new System.EventHandler(this.frmProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTheme;
        private MaterialSkin.Controls.MaterialSwitch msChangeTheme;
        private MaterialSkin.Controls.MaterialLabel lblMyProfile;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}