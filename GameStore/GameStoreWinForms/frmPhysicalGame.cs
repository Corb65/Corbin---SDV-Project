using GameStoreWinForms.ServiceReference1;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : A form inheriting from the superclass frmGenericGame and adding fields relevant to a physical subtype

namespace GameStoreWinForms
{
    public sealed partial class frmPhysical : GameStoreWinForms.frmGenericGame
    {
        private static readonly frmPhysical Instance = new frmPhysical();
        private frmPhysical()
        {
            InitializeComponent();
        }

        public static void Run(clsPhysical prPhysical)
        {
            Instance.SetDetails(prPhysical);
        }

        // Take data from the game object and display it in textboxes
        protected override void updateForm()
        {
            base.updateForm();
            clsPhysical lcGame = (clsPhysical)_Game;
            txtMediaType.Text = lcGame.MediaType.ToString();
            txtShipping.Text = lcGame.ShippingCost.ToString();
        }

        // Take data from textboxes and assign it to a game object for storage
        protected override void pushData()
        {
            base.pushData();
            clsPhysical lcGame = (clsPhysical)_Game;
            lcGame.MediaType = txtMediaType.Text;
            lcGame.ShippingCost = decimal.Parse(txtShipping.Text);
        }
    }
}
