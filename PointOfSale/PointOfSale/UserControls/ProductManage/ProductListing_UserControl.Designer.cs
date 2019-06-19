namespace PointOfSale.UserControls.ProductManage
{
    partial class ProductListing_UserControl
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
            this.components = new System.ComponentModel.Container();
            this.cmb_PL_PCategories = new System.Windows.Forms.ComboBox();
            this.lbl_PL_CategoriesCMB = new System.Windows.Forms.Label();
            this.lv_ProductListing = new System.Windows.Forms.ListView();
            this.pID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pStockUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanelMainBase = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelHead = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMainBase.SuspendLayout();
            this.flowLayoutPanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_PL_PCategories
            // 
            this.cmb_PL_PCategories.FormattingEnabled = true;
            this.cmb_PL_PCategories.Location = new System.Drawing.Point(69, 55);
            this.cmb_PL_PCategories.Margin = new System.Windows.Forms.Padding(3, 55, 3, 3);
            this.cmb_PL_PCategories.Name = "cmb_PL_PCategories";
            this.cmb_PL_PCategories.Size = new System.Drawing.Size(134, 21);
            this.cmb_PL_PCategories.TabIndex = 0;
            this.cmb_PL_PCategories.SelectedIndexChanged += new System.EventHandler(this.cmb_PL_PCategories_SelectedIndexChanged);
            // 
            // lbl_PL_CategoriesCMB
            // 
            this.lbl_PL_CategoriesCMB.AutoSize = true;
            this.lbl_PL_CategoriesCMB.Location = new System.Drawing.Point(3, 60);
            this.lbl_PL_CategoriesCMB.Margin = new System.Windows.Forms.Padding(3, 60, 3, 0);
            this.lbl_PL_CategoriesCMB.Name = "lbl_PL_CategoriesCMB";
            this.lbl_PL_CategoriesCMB.Size = new System.Drawing.Size(60, 13);
            this.lbl_PL_CategoriesCMB.TabIndex = 1;
            this.lbl_PL_CategoriesCMB.Text = "Categories:";
            // 
            // lv_ProductListing
            // 
            this.lv_ProductListing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pID,
            this.pName,
            this.pCode,
            this.pCompany,
            this.pStockUnit,
            this.pCategory});
            this.lv_ProductListing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_ProductListing.FullRowSelect = true;
            this.lv_ProductListing.GridLines = true;
            this.lv_ProductListing.Location = new System.Drawing.Point(139, 96);
            this.lv_ProductListing.Margin = new System.Windows.Forms.Padding(0);
            this.lv_ProductListing.MultiSelect = false;
            this.lv_ProductListing.Name = "lv_ProductListing";
            this.lv_ProductListing.Size = new System.Drawing.Size(651, 280);
            this.lv_ProductListing.StateImageList = this.imageList1;
            this.lv_ProductListing.TabIndex = 3;
            this.lv_ProductListing.UseCompatibleStateImageBehavior = false;
            this.lv_ProductListing.View = System.Windows.Forms.View.Details;
            this.lv_ProductListing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_ProductListing_MouseClick);
            this.lv_ProductListing.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_ProductListing_MouseDoubleClick);
            // 
            // pID
            // 
            this.pID.Text = "Product ID";
            this.pID.Width = 64;
            // 
            // pName
            // 
            this.pName.Text = "Product Name";
            this.pName.Width = 117;
            // 
            // pCode
            // 
            this.pCode.Text = "Code";
            this.pCode.Width = 70;
            // 
            // pCompany
            // 
            this.pCompany.Text = "Company";
            this.pCompany.Width = 89;
            // 
            // pStockUnit
            // 
            this.pStockUnit.Text = "Stock Unit";
            this.pStockUnit.Width = 90;
            // 
            // pCategory
            // 
            this.pCategory.Text = "Product Category";
            this.pCategory.Width = 96;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanelMainBase
            // 
            this.tableLayoutPanelMainBase.ColumnCount = 3;
            this.tableLayoutPanelMainBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMainBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.Controls.Add(this.lv_ProductListing, 1, 1);
            this.tableLayoutPanelMainBase.Controls.Add(this.flowLayoutPanelHead, 1, 0);
            this.tableLayoutPanelMainBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMainBase.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMainBase.Name = "tableLayoutPanelMainBase";
            this.tableLayoutPanelMainBase.RowCount = 3;
            this.tableLayoutPanelMainBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMainBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMainBase.Size = new System.Drawing.Size(930, 640);
            this.tableLayoutPanelMainBase.TabIndex = 4;
            // 
            // flowLayoutPanelHead
            // 
            this.flowLayoutPanelHead.Controls.Add(this.lbl_PL_CategoriesCMB);
            this.flowLayoutPanelHead.Controls.Add(this.cmb_PL_PCategories);
            this.flowLayoutPanelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHead.Location = new System.Drawing.Point(139, 0);
            this.flowLayoutPanelHead.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelHead.Name = "flowLayoutPanelHead";
            this.flowLayoutPanelHead.Size = new System.Drawing.Size(651, 96);
            this.flowLayoutPanelHead.TabIndex = 4;
            // 
            // ProductListing_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanelMainBase);
            this.Name = "ProductListing_UserControl";
            this.Size = new System.Drawing.Size(930, 640);
            this.Load += new System.EventHandler(this.ProductListing_UserControl_Load);
            this.tableLayoutPanelMainBase.ResumeLayout(false);
            this.flowLayoutPanelHead.ResumeLayout(false);
            this.flowLayoutPanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_PL_PCategories;
        private System.Windows.Forms.Label lbl_PL_CategoriesCMB;
        private System.Windows.Forms.ListView lv_ProductListing;
        private System.Windows.Forms.ColumnHeader pID;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.ColumnHeader pCode;
        private System.Windows.Forms.ColumnHeader pCompany;
        private System.Windows.Forms.ColumnHeader pStockUnit;
        private System.Windows.Forms.ColumnHeader pCategory;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainBase;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHead;
    }
}
