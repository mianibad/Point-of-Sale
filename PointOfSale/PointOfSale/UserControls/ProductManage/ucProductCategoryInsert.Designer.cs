namespace PointOfSale.UserControls.ProductManage
{
    partial class ucProductCategoryInsert
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMainBase = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.insert_CATAdd_button = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.insert_CATName_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMainBase.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMainBase
            // 
            this.tableLayoutPanelMainBase.ColumnCount = 3;
            this.tableLayoutPanelMainBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMainBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.Controls.Add(this.groupBox6, 1, 1);
            this.tableLayoutPanelMainBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMainBase.Name = "tableLayoutPanelMainBase";
            this.tableLayoutPanelMainBase.RowCount = 3;
            this.tableLayoutPanelMainBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMainBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.Size = new System.Drawing.Size(821, 549);
            this.tableLayoutPanelMainBase.TabIndex = 15;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.insert_CATAdd_button);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.insert_CATName_textBox);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(126, 85);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox6.Size = new System.Drawing.Size(568, 378);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Insert Category";
            // 
            // insert_CATAdd_button
            // 
            this.insert_CATAdd_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.insert_CATAdd_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_CATAdd_button.ForeColor = System.Drawing.Color.White;
            this.insert_CATAdd_button.Location = new System.Drawing.Point(323, 153);
            this.insert_CATAdd_button.Name = "insert_CATAdd_button";
            this.insert_CATAdd_button.Size = new System.Drawing.Size(75, 23);
            this.insert_CATAdd_button.TabIndex = 5;
            this.insert_CATAdd_button.Text = "Add";
            this.insert_CATAdd_button.UseVisualStyleBackColor = false;
            this.insert_CATAdd_button.Click += new System.EventHandler(this.insert_CATAdd_button_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(140, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Category Name:";
            // 
            // insert_CATName_textBox
            // 
            this.insert_CATName_textBox.Location = new System.Drawing.Point(270, 90);
            this.insert_CATName_textBox.Name = "insert_CATName_textBox";
            this.insert_CATName_textBox.Size = new System.Drawing.Size(128, 20);
            this.insert_CATName_textBox.TabIndex = 4;
            // 
            // ucProductCategoryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanelMainBase);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucProductCategoryInsert";
            this.Size = new System.Drawing.Size(821, 549);
            this.tableLayoutPanelMainBase.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainBase;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button insert_CATAdd_button;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox insert_CATName_textBox;
    }
}
