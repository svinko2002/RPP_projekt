namespace PresentationLayer.forms
{
    partial class UsersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersFrm));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAdministratorRequest = new System.Windows.Forms.Label();
            this.btnDecline = new System.Windows.Forms.Button();
            this.dgvUserRequests = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnSaveAsPDFUsers = new System.Windows.Forms.Button();
            this.btnSaveAsPDFRequests = new System.Windows.Forms.Button();
            this.btnRefreshRequests = new System.Windows.Forms.Button();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 110);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(776, 222);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEditUser.Location = new System.Drawing.Point(810, 291);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(175, 41);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Uredi korisnika";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblUser.Location = new System.Drawing.Point(12, 87);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Korisnici";
            // 
            // lblAdministratorRequest
            // 
            this.lblAdministratorRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdministratorRequest.AutoSize = true;
            this.lblAdministratorRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAdministratorRequest.Location = new System.Drawing.Point(12, 359);
            this.lblAdministratorRequest.Name = "lblAdministratorRequest";
            this.lblAdministratorRequest.Size = new System.Drawing.Size(187, 20);
            this.lblAdministratorRequest.TabIndex = 5;
            this.lblAdministratorRequest.Text = "Zahtjevi za organizatora";
            // 
            // btnDecline
            // 
            this.btnDecline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDecline.Location = new System.Drawing.Point(810, 446);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(175, 41);
            this.btnDecline.TabIndex = 4;
            this.btnDecline.Text = "Odbij";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // dgvUserRequests
            // 
            this.dgvUserRequests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRequests.Location = new System.Drawing.Point(12, 382);
            this.dgvUserRequests.Name = "dgvUserRequests";
            this.dgvUserRequests.Size = new System.Drawing.Size(776, 167);
            this.dgvUserRequests.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAccept.Location = new System.Drawing.Point(810, 382);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(175, 41);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Prihvati";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnSaveAsPDFUsers
            // 
            this.btnSaveAsPDFUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveAsPDFUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDFUsers.Location = new System.Drawing.Point(641, 74);
            this.btnSaveAsPDFUsers.Name = "btnSaveAsPDFUsers";
            this.btnSaveAsPDFUsers.Size = new System.Drawing.Size(147, 30);
            this.btnSaveAsPDFUsers.TabIndex = 20;
            this.btnSaveAsPDFUsers.Text = "Spremi kao PDF";
            this.btnSaveAsPDFUsers.UseVisualStyleBackColor = true;
            this.btnSaveAsPDFUsers.Click += new System.EventHandler(this.btnSaveAsPDFUsers_Click);
            // 
            // btnSaveAsPDFRequests
            // 
            this.btnSaveAsPDFRequests.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveAsPDFRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDFRequests.Location = new System.Drawing.Point(641, 349);
            this.btnSaveAsPDFRequests.Name = "btnSaveAsPDFRequests";
            this.btnSaveAsPDFRequests.Size = new System.Drawing.Size(147, 30);
            this.btnSaveAsPDFRequests.TabIndex = 21;
            this.btnSaveAsPDFRequests.Text = "Spremi kao PDF";
            this.btnSaveAsPDFRequests.UseVisualStyleBackColor = true;
            this.btnSaveAsPDFRequests.Click += new System.EventHandler(this.btnSaveAsPDFRequests_Click);
            // 
            // btnRefreshRequests
            // 
            this.btnRefreshRequests.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefreshRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefreshRequests.Location = new System.Drawing.Point(554, 347);
            this.btnRefreshRequests.Name = "btnRefreshRequests";
            this.btnRefreshRequests.Size = new System.Drawing.Size(81, 29);
            this.btnRefreshRequests.TabIndex = 22;
            this.btnRefreshRequests.Text = "Osvježi";
            this.btnRefreshRequests.UseVisualStyleBackColor = true;
            this.btnRefreshRequests.Click += new System.EventHandler(this.btnRefreshRequests_Click);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefreshUsers.Location = new System.Drawing.Point(554, 75);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(81, 29);
            this.btnRefreshUsers.TabIndex = 23;
            this.btnRefreshUsers.Text = "Osvježi";
            this.btnRefreshUsers.UseVisualStyleBackColor = true;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // UsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 578);
            this.Controls.Add(this.btnRefreshUsers);
            this.Controls.Add(this.btnRefreshRequests);
            this.Controls.Add(this.btnSaveAsPDFRequests);
            this.Controls.Add(this.btnSaveAsPDFUsers);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblAdministratorRequest);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.dgvUserRequests);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.dgvUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1031, 578);
            this.Name = "UsersFrm";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prikaz korisnika i zahtjeva za organizatore";
            this.Load += new System.EventHandler(this.UsersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblAdministratorRequest;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.DataGridView dgvUserRequests;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnSaveAsPDFUsers;
        private System.Windows.Forms.Button btnSaveAsPDFRequests;
        private System.Windows.Forms.Button btnRefreshRequests;
        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}