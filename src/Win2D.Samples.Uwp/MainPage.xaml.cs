using System;
using Windows.UI.Xaml.Controls;

namespace Win2D.Samples.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var selectedItem = (Windows.UI.Xaml.Controls.NavigationViewItem)args.SelectedItem;
            var selectedItemTag = ((string)selectedItem.Tag);
            var pageName = "Win2D.Samples.Uwp.Pages." + selectedItemTag;

            Type pageType = Type.GetType(pageName);

            RootFrame.Navigate(pageType);
        }
    }
}
