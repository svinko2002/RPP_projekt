namespace PresentationLayer
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSaveAsPDF = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNameOfCategory = new System.Windows.Forms.TextBox();
            this.lblNewCategory2 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(27, 142);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(417, 260);
            this.dgvCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(23, 119);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategorije";
            // 
            // btnSaveAsPDF
            // 
            this.btnSaveAsPDF.Location = new System.Drawing.Point(327, 109);
            this.btnSaveAsPDF.Name = "btnSaveAsPDF";
            this.btnSaveAsPDF.Size = new System.Drawing.Size(117, 27);
            this.btnSaveAsPDF.TabIndex = 4;
            this.btnSaveAsPDF.Text = "Spremi kao PDF";
            this.btnSaveAsPDF.UseVisualStyleBackColor = true;
            this.btnSaveAsPDF.Click += new System.EventHandler(this.btnSaveAsPDF_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(522, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 41);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(522, 189);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(169, 41);
            this.btnRequest.TabIndex = 20;
            this.btnRequest.Text = "Zahtjevi";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(599, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(482, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNameOfCategory
            // 
            this.txtNameOfCategory.Location = new System.Drawing.Point(482, 272);
            this.txtNameOfCategory.MaxLength = 20;
            this.txtNameOfCategory.Name = "txtNameOfCategory";
            this.txtNameOfCategory.Size = new System.Drawing.Size(192, 20);
            this.txtNameOfCategory.TabIndex = 26;
            this.txtNameOfCategory.Visible = false;
            // 
            // lblNewCategory2
            // 
            this.lblNewCategory2.AutoSize = true;
            this.lblNewCategory2.Location = new System.Drawing.Point(482, 253);
            this.lblNewCategory2.Name = "lblNewCategory2";
            this.lblNewCategory2.Size = new System.Drawing.Size(85, 13);
            this.lblNewCategory2.TabIndex = 29;
            this.lblNewCategory2.Text = "Nova kategorija:";
            this.lblNewCategory2.Visible = false;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 434);
            this.Controls.Add(this.lblNewCategory2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNameOfCategory);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSaveAsPDF);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dgvCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategories";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSaveAsPDF;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNameOfCategory;
        private System.Windows.Forms.Label lblNewCategory2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}