using System;
using System.Windows.Forms;
using GameStoreWinForms.ServiceReference1;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Populate a listbox with order details and allow deletion of these orders (NYI)

namespace GameStoreWinForms
{
    public sealed partial class frmOrderList : Form
    {
        //Singleton
        private static readonly frmOrderList _Instance = new frmOrderList();

        private frmOrderList()
        {
            InitializeComponent();
        }

        public static frmOrderList Instance
        {
            get { return frmOrderList._Instance; }
        }

        public void UpdateDisplay()
        {
            // Clear the listbox data and retrieve new data
            lstOrders.DataSource = null;
            lstOrders.DataSource = Program.SvcClient.GetOrderSummary();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey = Convert.ToString(lstOrders.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting an order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    {
                        clsOrder lcOrder = new clsOrder() { CustomerName = lcKey };
                        Program.SvcClient.DeleteOrder(lcOrder);

                        lstOrders.ClearSelected();
                        UpdateDisplay();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting Order");
                }

            int lcIndex = lstOrders.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting an order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.SvcClient.DeleteOrder(lstOrders.SelectedItem as clsOrder);
                UpdateDisplay();
            }
        }

        private void frmOrderList_Shown(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
