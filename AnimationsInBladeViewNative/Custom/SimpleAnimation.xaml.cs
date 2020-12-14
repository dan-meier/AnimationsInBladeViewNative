using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;

namespace AnimationsInBladeViewNative.Custom
{
    public sealed partial class SimpleAnimation : UserControl
    {
        public SimpleAnimation()
        {
            this.InitializeComponent();
        }

        private bool isHidden = false;
        private async void AnimateButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            AnimateButton.IsEnabled = false;  // Disable the button while the animation is in progress


            ElementTranslationStoryboard.Children[0].SetValue( DoubleAnimation.FromProperty, isHidden ? -200 : 0 );
            ElementTranslationStoryboard.Children[0].SetValue( DoubleAnimation.ToProperty,   isHidden ? 0 : -200 );
            ElementTranslationStoryboard.Begin();

            if (isHidden) FadeInStoryboard.Begin();
            else          FadeOutStoryboard.Begin();


            await Task.Delay( 1000 );
            AnimateButton.IsEnabled = true; // Re-enable the button when the animation is complete

            
            AnimateButton.Content = (string)AnimateButton.Content == "Fly In" ? "Fly Out" : "Fly In";
            isHidden              = ! isHidden;
        }
    }
}
