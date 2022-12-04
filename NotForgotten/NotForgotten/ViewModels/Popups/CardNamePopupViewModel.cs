using MvvmHelpers.Commands;
using NotForgotten.Views.Popups;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class CardNamePopupViewModel : BasePopupViewModel
    {
        public CardNamePopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand ProceedCommand => new AsyncCommand(OnProceedCommand);

        private async Task OnProceedCommand()
        {
            GoBackPopupCommand.Execute(null);
            await _popupNavigation.PushAsync(new AllTimeFavoritePopupView());
        }
    }
}
