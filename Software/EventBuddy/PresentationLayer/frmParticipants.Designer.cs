namespace PresentationLayer
{
    partial class frmParticipants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipants));
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnSaveAsPDF = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Location = new System.Drawing.Point(12, 103);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.Size = new System.Drawing.Size(475, 253);
            this.dgvParticipants.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(501, 194);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 34);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Izbaci";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBan
            // 
            this.btnBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBan.Location = new System.Drawing.Point(501, 154);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(121, 34);
            this.btnBan.TabIndex = 2;
            this.btnBan.Text = "Zabrani pristup";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnSaveAsPDF
            // 
            this.btnSaveAsPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAsPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDF.Location = new System.Drawing.Point(340, 67);
            this.btnSaveAsPDF.Name = "btnSaveAsPDF";
            this.btnSaveAsPDF.Size = new System.Drawing.Size(147, 30);
            this.btnSaveAsPDF.TabIndex = 20;
            this.btnSaveAsPDF.Text = "Spremi kao PDF";
            this.btnSaveAsPDF.UseVisualStyleBackColor = true;
            this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
            // 
            // frmParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 367);
            this.Controls.Add(this.btnSaveAsPDF);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvParticipants);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(646, 367);
            this.Name = "frmParticipants";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmParticipants";
            this.Load += new System.EventHandler(this.frmParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}