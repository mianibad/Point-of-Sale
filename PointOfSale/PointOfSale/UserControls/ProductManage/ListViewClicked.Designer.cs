namespace PointOfSale
{
    partial class ListViewClicked
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblstockUnit = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txt_PStock = new System.Windows.Forms.TextBox();
            this.txt_PCompany = new System.Windows.Forms.TextBox();
            this.txt_PCode = new System.Windows.Forms.TextBox();
            this.txt_PName = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(96, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(211, 37);
            this.headerLabel.TabIndex = 15;
            this.headerLabel.Text = "Product Details";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblstockUnit);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txt_PStock);
            this.groupBox1.Controls.Add(this.txt_PCompany);
            this.groupBox1.Controls.Add(this.txt_PCode);
            this.groupBox1.Controls.Add(this.txt_PName);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Location = new System.Drawing.Point(42, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 298);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(122, 188);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(168, 21);
            this.cmbCategory.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(122, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(24, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(21, 191);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Category:";
            // 
            // lblstockUnit
            // 
            this.lblstockUnit.AutoSize = true;
            this.lblstockUnit.Location = new System.Drawing.Point(21, 150);
            this.lblstockUnit.Name = "lblstockUnit";
            this.lblstockUnit.Size = new System.Drawing.Size(60, 13);
            this.lblstockUnit.TabIndex = 23;
            this.lblstockUnit.Text = "Stock Unit:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(21, 111);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 13);
            this.lblCompany.TabIndex = 22;
            this.lblCompany.Text = "Company:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(21, 72);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 13);
            this.lblCode.TabIndex = 21;
            this.lblCode.Text = "Code:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name:";
            // 
            // txt_PStock
            // 
            this.txt_PStock.Location = new System.Drawing.Point(122, 147);
            this.txt_PStock.Name = "txt_PStock";
            this.txt_PStock.Size = new System.Drawing.Size(168, 20);
            this.txt_PStock.TabIndex = 19;
            // 
            // txt_PCompany
            // 
            this.txt_PCompany.Location = new System.Drawing.Point(122, 108);
            this.txt_PCompany.Name = "txt_PCompany";
            this.txt_PCompany.Size = new System.Drawing.Size(168, 20);
            this.txt_PCompany.TabIndex = 18;
            // 
            // txt_PCode
            // 
            this.txt_PCode.Location = new System.Drawing.Point(122, 69);
            this.txt_PCode.Name = "txt_PCode";
            this.txt_PCode.Size = new System.Drawing.Size(168, 20);
            this.txt_PCode.TabIndex = 17;
            // 
            // txt_PName
            // 
            this.txt_PName.Location = new System.Drawing.Point(122, 29);
            this.txt_PName.Name = "txt_PName";
            this.txt_PName.Size = new System.Drawing.Size(168, 20);
            this.txt_PName.TabIndex = 16;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(215, 246);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ListViewClicked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(400, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListViewClicked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListViewClicked";
            this.Load += new System.EventHandler(this.ListViewClicked_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblstockUnit;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txt_PStock;
        private System.Windows.Forms.TextBox txt_PCompany;
        private System.Windows.Forms.TextBox txt_PCode;
        private System.Windows.Forms.TextBox txt_PName;
        private System.Windows.Forms.Button btn_Cancel;
    }
}