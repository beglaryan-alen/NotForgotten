using NotForgotten.ViewModels;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace NotForgotten.Views
{
    public partial class CategorizeView : ContentPage
    {
        public CategorizeView()
        {
            InitializeComponent();
            BindingContext = new CategorizeViewModel(Navigation);
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            if (expander.IsExpanded)
            {
                arrowImage.RotateTo(0);
            }
            else
            {
                arrowImage.RotateTo(180);
            }
        }
    }
}