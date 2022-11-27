using NotForgotten.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel(INavigation navigation) : base(navigation)
        {

        }

        public ICommand SubmitCommand => new Command(() => App.Current.MainPage = new RootView());
    }
}
