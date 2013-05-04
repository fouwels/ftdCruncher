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
using ftdCruncher.Templates;
using ftdCruncher.data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ftdCruncher
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var rnd = new Random();
            FilingCabinet.CountryProfiles.Add(new CountryProfile
                {
                    Name = "Country1",
                    Thing1 = rnd.Next(0, 101),
                    Thing2 = rnd.Next(0, 101),
                    Thing3 = rnd.Next(0, 101),
                    Thing4 = rnd.Next(0, 101)
                });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
                {
                    Name = "Country2",
                    Thing1 = rnd.Next(0, 101),
                    Thing2 = rnd.Next(0, 101),
                    Thing3 = rnd.Next(0, 101),
                    Thing4 = rnd.Next(0, 101)
                });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
                {
                    Name = "Country3",
                    Thing1 = rnd.Next(0, 101),
                    Thing2 = rnd.Next(0, 101),
                    Thing3 = rnd.Next(0, 101),
                    Thing4 = rnd.Next(0, 101)
                });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
                {
                    Name = "Country4",
                    Thing1 = rnd.Next(0, 101),
                    Thing2 = rnd.Next(0, 101),
                    Thing3 = rnd.Next(0, 101),
                    Thing4 = rnd.Next(0, 101)
                });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
                {
                    Name = "Country5",
                    Thing1 = rnd.Next(0, 101),
                    Thing2 = rnd.Next(0, 101),
                    Thing3 = rnd.Next(0, 101),
                    Thing4 = rnd.Next(0, 101)
                });

            MainContentWindow.DataContext = FilingCabinet.CountryProfiles;
        }
    }
}
