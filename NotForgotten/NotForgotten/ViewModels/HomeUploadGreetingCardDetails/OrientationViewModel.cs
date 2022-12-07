using NotForgotten.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.HomeUploadGreetingCardDetails
{
    public class OrientationViewModel : BaseViewModel
    {
        public OrientationViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand VerticalCommand => new Command(() => App.Current.MainPage = new RootView(0, true));
        public ICommand HorizontalCommand => new Command(() => App.Current.MainPage = new RootView(0));
    }
}
