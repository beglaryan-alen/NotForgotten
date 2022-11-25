using NotForgotten.ViewModels;
using Xamarin.Forms;

namespace NotForgotten.Views
{
    public partial class RootView : ContentPage
    {
        public RootView()
        {
            InitializeComponent();
            BindingContext = new RootViewModel(Navigation);
        }

    }
}