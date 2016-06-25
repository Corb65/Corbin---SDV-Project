namespace GameStoreWinForms
{
    partial class frmPhysical
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
            this.txtMediaType = new System.Windows.Forms.TextBox();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMediaType
            // 
            this.txtMediaType.Location = new System.Drawing.Point(348, 135);
            this.txtMediaType.Name = "txtMediaType";
            this.txtMediaType.Size = new System.Drawing.Size(174, 20);
            this.txtMediaType.TabIndex = 18;
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(348, 161);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.Size = new System.Drawing.Size(174, 20);
            this.txtShipping.TabIndex = 19;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(276, 138);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(66, 13);
            this.lblMedia.TabIndex = 20;
            this.lblMedia.Text = "Media Type:";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(291, 164);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(51, 13);
            this.lblShipping.TabIndex = 21;
            this.lblShipping.Text = "Shipping:";
            // 
            // frmPhysical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtShipping);
            this.Controls.Add(this.txtMediaType);
            this.Name = "frmPhysical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameShop: Viewing Physical Game";
            this.Controls.SetChildIndex(this.txtMediaType, 0);
            this.Controls.SetChildIndex(this.txtShipping, 0);
            this.Controls.SetChildIndex(this.lblMedia, 0);
            this.Controls.SetChildIndex(this.lblShipping, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMediaType;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblShipping;
    }
}
