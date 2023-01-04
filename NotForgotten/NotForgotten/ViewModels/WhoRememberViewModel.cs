using NotForgotten.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class WhoRememberViewModel : BaseViewModel
    {
        public WhoRememberViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand SubmitForArchive => new Command(() => App.Current.MainPage = new RootView(1));
    }
}
