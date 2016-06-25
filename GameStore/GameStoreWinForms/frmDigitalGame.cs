using GameStoreWinForms.ServiceReference1;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : A form inheriting from the superclass frmGenericGame and adding fields relevant to a digital subtype


namespace GameStoreWinForms
{
    public sealed partial class frmDigitalGame : GameStoreWinForms.frmGenericGame
    {
        private static readonly frmDigitalGame Instance = new frmDigitalGame();
        private frmDigitalGame()
        {
            InitializeComponent();
        }

        public static void Run(clsDigital prDigital)
        {
            Instance.SetDetails(prDigital);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsDigital lcDigital = (clsDigital)_Game;
            txtGameKey.Text = lcDigital.GameKey;
            txtPlatform.Text = lcDigital.Platform;
        }

        protected override void pushData()
        {
            base.pushData();
            clsDigital lcDigital = (clsDigital)_Game;
            lcDigital.GameKey = txtGameKey.Text;
            lcDigital.Platform = txtPlatform.Text;
        }
    }
}
