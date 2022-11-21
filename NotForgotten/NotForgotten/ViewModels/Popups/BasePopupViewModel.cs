using MvvmHelpers.Commands;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class BasePopupViewModel : BaseViewModel
    {
        public BasePopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand GoBackPopupCommand => new AsyncCommand(async () => await _popupNavigation.PopAsync());
    }

}
