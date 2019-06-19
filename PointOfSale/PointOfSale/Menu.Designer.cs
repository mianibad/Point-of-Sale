namespace PointOfSale
{
    partial class Menu
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
            this.btnProdManage = new System.Windows.Forms.Button();
            this.btnInventManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdManage
            // 
            this.btnProdManage.Location = new System.Drawing.Point(365, 129);
            this.btnProdManage.Name = "btnProdManage";
            this.btnProdManage.Size = new System.Drawing.Size(165, 65);
            this.btnProdManage.TabIndex = 0;
            this.btnProdManage.Text = "Product Management";
            this.btnProdManage.UseVisualStyleBackColor = true;
            this.btnProdManage.Click += new System.EventHandler(this.btnProdManage_Click);
            // 
            // btnInventManage
            // 
            this.btnInventManage.Location = new System.Drawing.Point(365, 229);
            this.btnInventManage.Name = "btnInventManage";
            this.btnInventManage.Size = new System.Drawing.Size(165, 65);
            this.btnInventManage.TabIndex = 1;
            this.btnInventManage.Text = "Inventory Management";
            this.btnInventManage.UseVisualStyleBackColor = true;
            this.btnInventManage.Click += new System.EventHandler(this.btnInventManage_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 470);
            this.Controls.Add(this.btnInventManage);
            this.Controls.Add(this.btnProdManage);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdManage;
        private System.Windows.Forms.Button btnInventManage;
    }
}