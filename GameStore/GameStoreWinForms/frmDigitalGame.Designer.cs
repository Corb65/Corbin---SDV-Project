namespace GameStoreWinForms
{
    partial class frmDigitalGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.txtGameKey = new System.Windows.Forms.TextBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblGameKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Digital Game Info";
            // 
            // txtPlatform
            // 
            this.txtPlatform.Location = new System.Drawing.Point(348, 138);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.Size = new System.Drawing.Size(174, 20);
            this.txtPlatform.TabIndex = 19;
            // 
            // txtGameKey
            // 
            this.txtGameKey.Location = new System.Drawing.Point(250, 168);
            this.txtGameKey.Name = "txtGameKey";
            this.txtGameKey.Size = new System.Drawing.Size(272, 20);
            this.txtGameKey.TabIndex = 20;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(294, 141);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(48, 13);
            this.lblPlatform.TabIndex = 21;
            this.lblPlatform.Text = "Platform:";
            // 
            // lblGameKey
            // 
            this.lblGameKey.AutoSize = true;
            this.lblGameKey.Location = new System.Drawing.Point(185, 171);
            this.lblGameKey.Name = "lblGameKey";
            this.lblGameKey.Size = new System.Drawing.Size(59, 13);
            this.lblGameKey.TabIndex = 22;
            this.lblGameKey.Text = "Game Key:";
            // 
            // frmDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.lblGameKey);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.txtGameKey);
            this.Controls.Add(this.txtPlatform);
            this.Controls.Add(this.label1);
            this.Name = "frmDigital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameShop: Viewing Digital Game";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtPlatform, 0);
            this.Controls.SetChildIndex(this.txtGameKey, 0);
            this.Controls.SetChildIndex(this.lblPlatform, 0);
            this.Controls.SetChildIndex(this.lblGameKey, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.TextBox txtGameKey;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblGameKey;
    }
}
