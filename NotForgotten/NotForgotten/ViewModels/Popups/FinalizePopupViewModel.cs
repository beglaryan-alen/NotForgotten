using MvvmHelpers.Commands;
using NotForgotten.Views.Popups;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class FinalizePopupViewModel : BasePopupViewModel
    {
        public FinalizePopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand FinalizeCommand => new AsyncCommand(OnFinalizeCommand);

        private async Task OnFinalizeCommand()
        {
            GoBackPopupCommand.Execute(null);
            await _popupNavigation.PushAsync(new ArchiveSuccessPopupView());
        }
    }
}
