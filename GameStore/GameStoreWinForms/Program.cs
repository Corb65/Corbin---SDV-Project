using System;
using System.Windows.Forms;
using GameStoreWinForms.ServiceReference1;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Define the service client, define delegates for subclasses, and specify the first form

namespace GameStoreWinForms
{
    public static class Program
    {
        public static ServiceReference1.Service1Client SvcClient = new ServiceReference1.Service1Client();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsPhysical.LoadPhysicalForm = new clsPhysical.LoadPhysicalFormDelegate(frmPhysical.Run);
            clsDigital.LoadDigitalForm = new clsDigital.LoadDigitalFormDelegate(frmDigitalGame.Run);
            Application.Run(frmMain.Instance);
            if (SvcClient != null &&
                    SvcClient.State != System.ServiceModel.CommunicationState.Closed)
                SvcClient.Close();
        }
    }
}
