using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ftdCruncher.Pages;
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
            FilingCabinet.CountryProfiles.Clear();
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Albania",
                LatestYear = 2009,
                Oil_Production = 3467500,
                Oil_Price = 0,
                Gas_Production = 0,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Azerbaijan",
                LatestYear = 2010,
                Oil_Production = 0,
                Oil_Price = 79.5,
                Gas_Production = 0,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Congo",
                LatestYear = 2007,
                Oil_Production = 8086940,
                Oil_Price = 0,
                Gas_Production = 0,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Guinea",
                LatestYear = 2006,
                Oil_Production = 87000000,
                Oil_Price = 70,
                Gas_Production = 0,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Ivory Coast",
                LatestYear = 2007,
                Oil_Production = 17500000,
                Oil_Price = 70.93,
                Gas_Production = 13808369722,
                Gas_Price = 0.227647
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Kazakhstan",
                LatestYear = 2009,
                Oil_Production = 616120000,
                Oil_Price = 61.66,
                Gas_Production = 32500000000,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Kyrgyzstan",
                LatestYear = 2009,
                Oil_Production = 0,
                Oil_Price = 61.66,
                Gas_Production = 0,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Mauritania",
                LatestYear = 2009,
                Oil_Production = 1870000,
                Oil_Price = 61.66,
                Gas_Production = 3037000000,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Mongolia",
                LatestYear = 2009,
                Oil_Production = 1870000,
                Oil_Price = 61.66,
                Gas_Production = 0,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Mozambiq.",
                LatestYear = 2008,
                Oil_Production = 0,
                Oil_Price = 0,
                Gas_Production = 3037000000,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Nigeria",
                LatestYear = 2008,
                Oil_Production = 774456000,
                Oil_Price = 101.43,
                Gas_Production = 35000000000,
                Gas_Price = 0.328797
            });

            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Norway",
                LatestYear = 2009,
                Oil_Production = 854830000,
                Oil_Price = 61.66,
                Gas_Production = 2661781071,
                Gas_Price = 0.227647
            });

            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Peru",
                LatestYear = 2007,
                Oil_Production = 774456000,
                Oil_Price = 101.43,
                Gas_Production = 35000000000,
                Gas_Price = 0.328797
            });

            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Tanzania",
                LatestYear = 2009,
                Oil_Production = 608811628,
                Oil_Price = 0.473025,
                Gas_Production = 0,
                Gas_Price = 0
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Timor Leste",
                LatestYear = 2008,
                Oil_Production = 608811628,
                Oil_Price = 0.473025,
                Gas_Production = 0,
                Gas_Price = 0.328797
            });
            FilingCabinet.CountryProfiles.Add(new CountryProfile
            {
                Name = "Yemen",
                LatestYear = 2005,
                Oil_Production = 151840000,
                Oil_Price = 51.448448,
                Gas_Production = 0,
                Gas_Price = 53.49
            });
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainContentWindow.DataContext = FilingCabinet.CountryProfiles;
        }

        private void MainContentWindow_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            if (!(MainContentWindow.SelectedItems.Count < 2))
            {
                var fr = new Frame();
                fr.Navigate(typeof(ComparePage), MainContentWindow);
                Window.Current.Content = fr;
                Window.Current.Activate();
            }
        }
    }
}
