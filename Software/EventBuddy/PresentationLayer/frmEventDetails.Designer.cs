namespace PresentationLayer
{
    partial class frmEventDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventDetails));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblOverView = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPlace = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 413);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dtpDate, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDate, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtpTime, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOverView, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtLocation, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblPlace, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(503, 304);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.dtpDate, 2);
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(203, 123);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(194, 29);
            this.dtpDate.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblDate.Location = new System.Drawing.Point(103, 120);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 24);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Datum";
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Location = new System.Drawing.Point(203, 163);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(94, 29);
            this.dtpTime.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblName.Location = new System.Drawing.Point(103, 0);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naziv";
            // 
            // lblOverView
            // 
            this.lblOverView.AutoSize = true;
            this.lblOverView.Depth = 0;
            this.lblOverView.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblOverView.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblOverView.Location = new System.Drawing.Point(103, 40);
            this.lblOverView.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOverView.Name = "lblOverView";
            this.lblOverView.Size = new System.Drawing.Size(41, 24);
            this.lblOverView.TabIndex = 3;
            this.lblOverView.Text = "Opis";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.txtName, 2);
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtName.Location = new System.Drawing.Point(203, 3);
            this.txtName.MaxLength = 50;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 36);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "";
            this.txtName.UseTallSize = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDescription.Location = new System.Drawing.Point(203, 43);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 36);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            this.txtDescription.UseTallSize = false;
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.txtLocation, 2);
            this.txtLocation.Depth = 0;
            this.txtLocation.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLocation.Location = new System.Drawing.Point(203, 83);
            this.txtLocation.MaxLength = 250;
            this.txtLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLocation.Multiline = false;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(194, 36);
            this.txtLocation.TabIndex = 9;
            this.txtLocation.Text = "";
            this.txtLocation.UseTallSize = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(103, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(303, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Depth = 0;
            this.lblPlace.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPlace.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblPlace.Location = new System.Drawing.Point(103, 80);
            this.lblPlace.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(63, 24);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "Mjesto";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox2.Location = new System.Drawing.Point(303, 43);
            this.materialTextBox2.MaxLength = 250;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(194, 36);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.UseTallSize = false;
            // 
            // frmEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(545, 490);
            this.Name = "frmEventDetails";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEventDetails";
            this.Load += new System.EventHandler(this.frmEventDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblOverView;
        private MaterialSkin.Controls.MaterialLabel lblPlace;
        private MaterialSkin.Controls.MaterialLabel lblDate;
        private MaterialSkin.Controls.MaterialTextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private MaterialSkin.Controls.MaterialTextBox txtLocation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}