using NotForgotten.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class WhoRememberViewModel : BaseViewModel
    {
        public WhoRememberViewModel(INavigation navigation, RootView rootView = null) : base(navigation, rootView)
        {
        }

        public ICommand SubmitForArchive => new Command(() => App.Current.MainPage = new RootView(1));
    }
}
