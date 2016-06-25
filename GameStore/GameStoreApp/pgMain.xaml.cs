using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GameStoreApp.ServiceReference1;

// Name : Corbin Dickens || Date : 22.06.2016 || Purpose : Populate the list view with Genres from the service reference

namespace GameStoreApp
{
    public sealed partial class pgMain : Page
    {

        public static readonly Service1Client SvcClient = new Service1Client();
        public pgMain()
        {
            this.InitializeComponent();
        }

        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lstGenres.ItemsSource = await SvcClient.GetGenreNamesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
