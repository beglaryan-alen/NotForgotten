using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class AllTimeFavoritePopupViewModel : BasePopupViewModel
    {
        public AllTimeFavoritePopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand Continue => new AsyncCommand(OnContinue);

        private async Task OnContinue()
        {
            GoBackPopupCommand.Execute(null);
            await _navigation.PushModalAsync(new UploadGreetingCardView());
        }
    }
}
