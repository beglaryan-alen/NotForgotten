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

    }
}