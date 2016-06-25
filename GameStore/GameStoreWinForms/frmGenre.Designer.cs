namespace GameStoreWinForms
{
    partial class frmGenre
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
            this.lstGames = new System.Windows.Forms.ListBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.txtGenreDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(12, 77);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(381, 173);
            this.lstGames.TabIndex = 2;
            this.lstGames.DoubleClick += new System.EventHandler(this.lstGames_DoubleClick_1);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(399, 44);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(123, 47);
            this.btnAddGame.TabIndex = 3;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnEditGame
            // 
            this.btnEditGame.Location = new System.Drawing.Point(399, 97);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(123, 47);
            this.btnEditGame.TabIndex = 6;
            this.btnEditGame.Text = "Edit Game";
            this.btnEditGame.UseVisualStyleBackColor = true;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Location = new System.Drawing.Point(399, 150);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(123, 47);
            this.btnDeleteGame.TabIndex = 7;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(399, 203);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(123, 47);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Save and Close";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtGenreName
            // 
            this.txtGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.Location = new System.Drawing.Point(161, 12);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(232, 32);
            this.txtGenreName.TabIndex = 9;
            // 
            // txtGenreDescription
            // 
            this.txtGenreDescription.Location = new System.Drawing.Point(161, 50);
            this.txtGenreDescription.Name = "txtGenreDescription";
            this.txtGenreDescription.Size = new System.Drawing.Size(232, 20);
            this.txtGenreDescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Genre Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Genre Description:";
            // 
            // frmGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenreDescription);
            this.Controls.Add(this.txtGenreName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.lstGames);
            this.Name = "frmGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameShop: Viewing Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnEditGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.TextBox txtGenreDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}