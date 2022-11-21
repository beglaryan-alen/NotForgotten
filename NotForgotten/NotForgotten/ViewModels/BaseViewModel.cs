using MvvmHelpers.Commands;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class BaseViewModel
    {
        protected readonly IPopupNavigation _popupNavigation;
        protected readonly INavigation _navigation;
        public BaseViewModel(
            INavigation navigation)
        {
            _popupNavigation = DependencyService.Get<IPopupNavigation>();
            _navigation = navigation;
        }

        public ICommand GoBackCommand => new AsyncCommand(async() => await _navigation.PopModalAsync());

    }
}
