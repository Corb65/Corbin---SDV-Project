using GameStoreWinForms.ServiceReference1;
using System;
using System.Windows.Forms;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Provides the code to initilize and populate a list of genres

namespace GameStoreWinForms
{
    public sealed partial class frmMain : Form
    {
        //Singleton
        private static readonly frmMain _Instance = new frmMain();

        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
        }

        public void UpdateDisplay()
        {
            // Clear the data and retrieve new data
            lstGenres.DataSource = null;
            lstGenres.DataSource = Program.SvcClient.GetGenreNames();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            // Open the instance of the order list form
            frmOrderList OrderList = frmOrderList.Instance;
            OrderList.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void lstGenres_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstGenres.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmGenre.Run(lstGenres.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            try
            {
                frmGenre.Run(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new Genre");
            }
        }

        private void btnViewGames_Click(object sender, EventArgs e)
        {
            // NYI - Use double click routine instead
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            string lcKey = Convert.ToString(lstGenres.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting Genre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    clsGenre lcGenre = new clsGenre() { GenreName = lcKey };
                    Program.SvcClient.DeleteGenre(lcGenre);

                    lstGenres.ClearSelected();
                    UpdateDisplay();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting Genre");
                }
        }
    }
}
