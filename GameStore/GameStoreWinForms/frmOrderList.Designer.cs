namespace GameStoreWinForms
{
    partial class frmOrderList
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
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(12, 30);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(510, 121);
            this.lstOrders.TabIndex = 0;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(12, 9);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "Order Number";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(102, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 13);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer Name";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(203, 9);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(41, 13);
            this.lblItemID.TabIndex = 3;
            this.lblItemID.Text = "Item ID";
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(261, 9);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(58, 13);
            this.lblItemCount.TabIndex = 4;
            this.lblItemCount.Text = "Item Count";
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.AutoSize = true;
            this.lblOrderPrice.Location = new System.Drawing.Point(347, 9);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(40, 13);
            this.lblOrderPrice.TabIndex = 5;
            this.lblOrderPrice.Text = "Total $";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(412, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(64, 13);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "Date / Time";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(17, 163);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(68, 13);
            this.lblOrderTotal.TabIndex = 7;
            this.lblOrderTotal.Text = "Order Totals:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(91, 160);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(184, 20);
            this.txtOrderTotal.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(353, 208);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(169, 41);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.lblItemCount);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lstOrders);
            this.Name = "frmOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewing Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.Shown += new System.EventHandler(this.frmOrderList_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblOrderPrice;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
    }
}