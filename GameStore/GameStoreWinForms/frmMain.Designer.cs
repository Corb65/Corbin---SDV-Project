namespace GameStoreWinForms
{
    partial class frmMain
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
            this.lblOne = new System.Windows.Forms.Label();
            this.lstGenres = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnViewGames = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(12, 9);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(304, 26);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "WELCOME - Choose a Genre";
            // 
            // lstGenres
            // 
            this.lstGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGenres.FormattingEnabled = true;
            this.lstGenres.ItemHeight = 20;
            this.lstGenres.Location = new System.Drawing.Point(12, 38);
            this.lstGenres.Name = "lstGenres";
            this.lstGenres.Size = new System.Drawing.Size(381, 204);
            this.lstGenres.TabIndex = 1;
            this.lstGenres.DoubleClick += new System.EventHandler(this.lstGenres_DoubleClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(399, 195);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(123, 47);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(399, 155);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(123, 34);
            this.btnViewOrders.TabIndex = 3;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnViewGames
            // 
            this.btnViewGames.Location = new System.Drawing.Point(399, 115);
            this.btnViewGames.Name = "btnViewGames";
            this.btnViewGames.Size = new System.Drawing.Size(123, 34);
            this.btnViewGames.TabIndex = 4;
            this.btnViewGames.Text = "View Games";
            this.btnViewGames.UseVisualStyleBackColor = true;
            this.btnViewGames.Click += new System.EventHandler(this.btnViewGames_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(399, 35);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(123, 34);
            this.btnAddGenre.TabIndex = 5;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(399, 75);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(123, 34);
            this.btnDeleteGenre.TabIndex = 6;
            this.btnDeleteGenre.Text = "Delete Genre";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnViewGames);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstGenres);
            this.Controls.Add(this.lblOne);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameShop: View Genres";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.ListBox lstGenres;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnViewGames;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
    }
}