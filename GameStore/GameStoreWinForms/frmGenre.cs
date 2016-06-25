using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using GameStoreWinForms.ServiceReference1;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Display Genre details and the list of attatched games. Allow add/edit/delete of games

namespace GameStoreWinForms
{
    public partial class frmGenre : Form
    {
        private clsGenre _Genre;

        private static Dictionary<string, frmGenre> _GameFormList = new Dictionary<string, frmGenre>();

        public frmGenre()
        {
            InitializeComponent();
        }

        public static void Run(string prGenreName)
        {
            frmGenre lcGameForm;
            if (string.IsNullOrEmpty(prGenreName) ||
                !_GameFormList.TryGetValue(prGenreName, out lcGameForm))
            {
                lcGameForm = new frmGenre();
                if (string.IsNullOrEmpty(prGenreName))
                    lcGameForm.SetDetails(new clsGenre());
                else
                {
                    _GameFormList.Add(prGenreName, lcGameForm);
                    lcGameForm.refreshFormFromDB(prGenreName);
                }
            }
            else
            {
                lcGameForm.Show();
                lcGameForm.Activate();
            }
        }

        private void refreshFormFromDB(string prGenreName)
        {
            SetDetails(Program.SvcClient.GetGenre(prGenreName));
        }

        public void SetDetails(clsGenre prGenre)
        {
            _Genre = prGenre;
            txtGenreName.Enabled = string.IsNullOrEmpty(_Genre.GenreName);
            UpdateForm();
            UpdateDisplay();
            Show();
        }

        public void UpdateForm()
        {
            txtGenreName.Text = _Genre.GenreName;
            txtGenreDescription.Text = _Genre.GenreDescription;
        }

        public void UpdateDisplay()
        {
            lstGames.DataSource = null;
            if (_Genre.Games != null)
                lstGames.DataSource = _Genre.Games.ToList();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            try
            {
                string lcReply = new InputBox(clsGame.FACTORY_PROMPT).Answer;
                if (!string.IsNullOrEmpty(lcReply))
                {
                    clsGame lcGame = clsGame.NewGame(lcReply[0]);
                    if (lcGame != null)
                    {
                        if (txtGenreName.Enabled)
                        {
                            pushData();
                            Program.SvcClient.InsertGenre(_Genre);
                            txtGenreName.Enabled = false;
                        }
                        lcGame.GameGenre = _Genre.GenreName;
                        lcGame.EditDetails();
                        if (!string.IsNullOrEmpty(lcGame.GameName))
                        {
                            refreshFormFromDB(_Genre.GenreName);
                            frmMain.Instance.UpdateDisplay();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error adding");
            }
        }

        private void btnEditGame_Click(object sender, EventArgs e)
        {
            // NYI (Use double click routine instead)
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            // NYI
        }

        private void pushData()
        {
            try
            {
                _Genre.GenreName = txtGenreName.Text;
                _Genre.GenreDescription = txtGenreDescription.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Message);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            pushData();
            if (txtGenreName.Enabled)
            {
                try
                {
                    Program.SvcClient.InsertGenre(_Genre);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error saving Genre");
                }
                frmMain.Instance.UpdateDisplay();
                txtGenreName.Enabled = false;
            }
            else
                Program.SvcClient.UpdateGenre(_Genre);
            Hide();
        }

        private void lstGames_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                (lstGames.SelectedValue as clsGame).EditDetails();

                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}