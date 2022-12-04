using NotForgotten.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.UploadGreetingCardDetails
{
    public class OrientationViewModel : BaseViewModel
    {
        public OrientationViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand TappedCommad => new Command(() => App.Current.MainPage = new RootView(0));
    }
}
