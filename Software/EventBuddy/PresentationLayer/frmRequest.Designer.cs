namespace PresentationLayer
{
    partial class frmRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequest));
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.lblNewCategory = new System.Windows.Forms.Label();
            this.btnSaveAsPDF = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnModifyData = new System.Windows.Forms.Button();
            this.txtNameOfCategory = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequest
            // 
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Location = new System.Drawing.Point(12, 166);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.Size = new System.Drawing.Size(435, 263);
            this.dgvRequest.TabIndex = 3;
            // 
            // lblNewCategory
            // 
            this.lblNewCategory.AutoSize = true;
            this.lblNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblNewCategory.Location = new System.Drawing.Point(133, 72);
            this.lblNewCategory.Name = "lblNewCategory";
            this.lblNewCategory.Size = new System.Drawing.Size(414, 39);
            this.lblNewCategory.TabIndex = 4;
            this.lblNewCategory.Text = "Zahtjev za nove kategorije";
            // 
            // btnSaveAsPDF
            // 
            this.btnSaveAsPDF.Location = new System.Drawing.Point(330, 133);
            this.btnSaveAsPDF.Name = "btnSaveAsPDF";
            this.btnSaveAsPDF.Size = new System.Drawing.Size(117, 27);
            this.btnSaveAsPDF.TabIndex = 5;
            this.btnSaveAsPDF.Text = "Spremi kao PDF";
            this.btnSaveAsPDF.UseVisualStyleBackColor = true;
            this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(469, 166);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(169, 41);
            this.btnAccept.TabIndex = 20;
            this.btnAccept.Text = "Prihvati";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(469, 213);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(169, 41);
            this.btnReject.TabIndex = 21;
            this.btnReject.Text = "Odbaciti";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnModifyData
            // 
            this.btnModifyData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyData.Location = new System.Drawing.Point(469, 260);
            this.btnModifyData.Name = "btnModifyData";
            this.btnModifyData.Size = new System.Drawing.Size(169, 41);
            this.btnModifyData.TabIndex = 22;
            this.btnModifyData.Text = "Izmijeniti podatke";
            this.btnModifyData.UseVisualStyleBackColor = true;
            this.btnModifyData.Click += new System.EventHandler(this.btnModifyData_Click);
            // 
            // txtNameOfCategory
            // 
            this.txtNameOfCategory.Location = new System.Drawing.Point(453, 325);
            this.txtNameOfCategory.MaxLength = 20;
            this.txtNameOfCategory.Name = "txtNameOfCategory";
            this.txtNameOfCategory.Size = new System.Drawing.Size(192, 20);
            this.txtNameOfCategory.TabIndex = 23;
            this.txtNameOfCategory.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(453, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(570, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNameOfCategory);
            this.Controls.Add(this.btnModifyData);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnSaveAsPDF);
            this.Controls.Add(this.lblNewCategory);
            this.Controls.Add(this.dgvRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRequest";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zahtjev za kategoriju";
            this.Load += new System.EventHandler(this.frmRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.Label lblNewCategory;
        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnModifyData;
        private System.Windows.Forms.TextBox txtNameOfCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}