namespace PointOfSale.UserControls.BarCodeManage
{
    partial class BarCodeGenerator
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
            this.PB_BCDrawn = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BCDrawn)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_BCDrawn
            // 
            this.PB_BCDrawn.BackColor = System.Drawing.SystemColors.Window;
            this.PB_BCDrawn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_BCDrawn.Location = new System.Drawing.Point(35, 24);
            this.PB_BCDrawn.Name = "PB_BCDrawn";
            this.PB_BCDrawn.Size = new System.Drawing.Size(393, 183);
            this.PB_BCDrawn.TabIndex = 3;
            this.PB_BCDrawn.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(330, 213);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 37);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // BarCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 302);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.PB_BCDrawn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BarCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarCode Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarCodeGenerator_FormClosing);
            this.Load += new System.EventHandler(this.BarCodeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_BCDrawn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_BCDrawn;
        private System.Windows.Forms.Button btnPrint;
    }
}