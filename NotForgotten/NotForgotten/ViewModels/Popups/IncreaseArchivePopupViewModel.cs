using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class IncreaseArchivePopupViewModel : BasePopupViewModel
    {
        public IncreaseArchivePopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand Shop => new AsyncCommand(OnShop);

        private async Task OnShop()
        {
            GoBackPopupCommand.Execute(null);
            await _navigation.PushModalAsync(new PayView());
        }
    }
}
