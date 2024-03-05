namespace PresentationLayer.forms
{
    partial class HideEventFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HideEventFrm));
            this.btnHideEvent = new System.Windows.Forms.Button();
            this.btnRemoveRole = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnHideEvent
            // 
            this.btnHideEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnHideEvent.Location = new System.Drawing.Point(48, 75);
            this.btnHideEvent.Name = "btnHideEvent";
            this.btnHideEvent.Size = new System.Drawing.Size(187, 71);
            this.btnHideEvent.TabIndex = 1;
            this.btnHideEvent.Text = "Sakrij događaj sa slanjem upozorenja";
            this.btnHideEvent.UseVisualStyleBackColor = true;
            this.btnHideEvent.Click += new System.EventHandler(this.btnHideEvent_Click);
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRemoveRole.Location = new System.Drawing.Point(48, 152);
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(187, 70);
            this.btnRemoveRole.TabIndex = 2;
            this.btnRemoveRole.Text = "Makni ulogu organizatora";
            this.btnRemoveRole.UseVisualStyleBackColor = true;
            this.btnRemoveRole.Click += new System.EventHandler(this.btnRemoveRole_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQuit.Location = new System.Drawing.Point(48, 228);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(187, 70);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Odustani od sakrivanja";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // HideEventFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemoveRole);
            this.Controls.Add(this.btnHideEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HideEventFrm";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HideEventFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHideEvent;
        private System.Windows.Forms.Button btnRemoveRole;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}