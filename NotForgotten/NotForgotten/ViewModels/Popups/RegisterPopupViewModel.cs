using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class RegisterPopupViewModel : BasePopupViewModel
    {
        public RegisterPopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand RegisterCommand => new AsyncCommand(OnRegisterCommand);

        private async Task OnRegisterCommand()
        {
            
        }
    }
}
