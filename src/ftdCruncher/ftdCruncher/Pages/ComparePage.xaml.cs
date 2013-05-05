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
using ftdCruncher.data;


namespace ftdCruncher.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ComparePage : Page
    {
        public ComparePage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var x = (GridView) e.Parameter;
            CompareOne.DataContext = x.SelectedItems[0];
            CompareTwo.DataContext = x.SelectedItems[1];

        }

        private void backButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var fr = new Frame();
            fr.Navigate(typeof(MainPage));
            Window.Current.Content = fr;
            Window.Current.Activate();
        }
    }
}
