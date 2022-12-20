using NotForgotten.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WhoRememberView : ContentPage
    {
        public WhoRememberView()
        {
            InitializeComponent();
            BindingContext = new WhoRememberViewModel(Navigation);
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            if (expander.IsExpanded)
            {
                mapArrowImage.RotateTo(0);
            }
            else
            {
                mapArrowImage.RotateTo(180);
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, System.EventArgs e)
        {
            if (townExpander.IsExpanded)
            {
                townArrowImage.RotateTo(0);
            }
            else
            {
                townArrowImage.RotateTo(180);
            }
        }
    }
}