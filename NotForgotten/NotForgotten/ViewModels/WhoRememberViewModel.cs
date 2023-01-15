using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class WhoRememberViewModel : BaseViewModel
    {
        public WhoRememberViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand SubmitForArchive => new Command(async () => await OnSubmitCommand());

        private async Task OnSubmitCommand()
        {
            var loginView = new LoginView();
            App.Current.MainPage = loginView;
            await Task.Delay(100);
            (loginView.BindingContext as LoginViewModel).RegisterCommand.Execute(null);
        }
    }
}
