using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class EmailSentPopupViewModel : BasePopupViewModel
    {
        public EmailSentPopupViewModel(INavigation navigation) : base(navigation)
        {
        }

         public ICommand DoneCommand => new AsyncCommand(OnDoneCommand);

        private async Task OnDoneCommand()
        {
            GoBackPopupCommand.Execute(null);

            await _navigation.PushModalAsync(new SettingsView());
        }
    }
}
