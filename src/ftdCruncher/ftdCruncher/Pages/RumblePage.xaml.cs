using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ftdCruncher.Services;


namespace ftdCruncher.Pages
{
    public sealed partial class RumblePage : Page
    {
        public RumblePage()
        {
            this.InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            StatusMessage.Text = "Downloading Feeds";
            TheProgressRing.IsActive = true;
            //get feeds
            var myFapi = new FApi();
            var x = await myFapi.GetCountries();

            TheProgressRing.IsActive = false;
            var fr = new Frame();
            fr.Navigate(typeof(MainPage));
            Window.Current.Content = fr;
            Window.Current.Activate();
        }
    }
}
