using System;
using System.Windows.Forms;
using GameStoreWinForms.ServiceReference1;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Form containing fields and methods generic to all game types

namespace GameStoreWinForms
{
    public partial class frmGenericGame : Form
    {
        protected clsGame _Game;
        public frmGenericGame()
        {
            InitializeComponent();
        }

        public void SetDetails(clsGame prGame)
        {
            _Game = prGame;
            updateForm();
            ShowDialog();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();

                if (txtName.Enabled)
                    Program.SvcClient.InsertGame(_Game);
                else
                    Program.SvcClient.UpdateGame(_Game);
                Close();
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtName.Text = _Game.GameName;
            txtYear.Text = _Game.Year.ToString();
            txtStock.Text = _Game.Quantity.ToString();
            txtGenre.Text = _Game.GameGenre;
            txtPublisher.Text = _Game.Publisher;
            txtPrice.Text = _Game.Price.ToString();
            txtName.Enabled = string.IsNullOrEmpty(_Game.GameName);
        }

        protected virtual void pushData()
        {
            _Game.GameName = txtName.Text;
            _Game.Year = int.Parse(txtYear.Text);
            _Game.Quantity = int.Parse(txtStock.Text);
            _Game.GameGenre = txtGenre.Text;
            _Game.Publisher = txtPublisher.Text;
            _Game.Price = decimal.Parse(txtPrice.Text);
        }
    }
}