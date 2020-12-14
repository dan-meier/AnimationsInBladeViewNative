using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace AnimationsInBladeViewNative
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void ShowButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            ImplicitAnimationsBladeView.Visibility = Visibility.Visible;
            ImplicitAnimationsBladeItem.IsOpen     = true;

            ShowButton.IsEnabled                   = false;
            PageControl.IsEnabled                  = false;
        }

        private void HideButton_OnTapped( object sender, TappedRoutedEventArgs e )
        {
            ImplicitAnimationsBladeItem.IsOpen     = false;
            ImplicitAnimationsBladeView.Visibility = Visibility.Collapsed;

            ShowButton.IsEnabled                   = true;
            PageControl.IsEnabled                  = true;
        }
    }
}
