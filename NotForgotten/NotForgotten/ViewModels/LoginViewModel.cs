using MvvmHelpers.Commands;
using NotForgotten.Views;
using NotForgotten.Views.Popups;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand ForgottenPasswordCommand => new AsyncCommand(OnForgottenPasswordCommand);
        public ICommand RegisterCommand => new AsyncCommand(OnRegisterCommand);
        public ICommand LoginCommand => new AsyncCommand(OnLoginCommand);

        private async Task OnRegisterCommand()
        {
            await _popupNavigation.PushAsync(new RegisterPopupView());
        }

        private async Task OnForgottenPasswordCommand()
        {
            await _navigation.PushModalAsync(new ResetPasswordView());
        }

        private async Task OnLoginCommand()
        {
            App.Current.MainPage = new RootView(1);
        }
    }
}
