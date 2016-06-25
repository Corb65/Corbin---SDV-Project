using System;
using System.Windows.Forms;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : A dialog box asking for one letter of input to define which subclass type is needed

namespace GameStoreWinForms
{
    public partial class InputBox : Form
    {

        private string _Answer;
        public InputBox(string question)
        {
            InitializeComponent();
            lblQuestion.Text = question;
            lblError.Text = "";
            txtInput.Focus();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _Answer = txtInput.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Answer
        {
            get { return _Answer; }
        }
    }
}
