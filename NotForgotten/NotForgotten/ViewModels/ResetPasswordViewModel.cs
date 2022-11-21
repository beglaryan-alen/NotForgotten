using MvvmHelpers.Commands;
using NotForgotten.Views.Popups;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class ResetPasswordViewModel : BaseViewModel
    {
        public ResetPasswordViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand SubmitCommand => new AsyncCommand(OnSubmitCommand);

        private async Task OnSubmitCommand()
        {
            await _popupNavigation.PushAsync(new EmailSentPopupView());
        }
    }
}
