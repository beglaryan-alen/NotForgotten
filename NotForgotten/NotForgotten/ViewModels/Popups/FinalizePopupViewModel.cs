using MvvmHelpers.Commands;
using NotForgotten.Views.Popups;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class FinalizePopupViewModel : BasePopupViewModel
    {
        public FinalizePopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand FinalizeCommand => new AsyncCommand(async () => await _popupNavigation.PushAsync(new ArchiveSuccessPopupView()));
    }
}
