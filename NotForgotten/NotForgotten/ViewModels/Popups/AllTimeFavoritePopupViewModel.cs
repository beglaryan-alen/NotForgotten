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

        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set => SetProperty(ref _isFavorite, value);
        }

        public ICommand FavoriteCommand => new AsyncCommand(async() => IsFavorite = !IsFavorite);

        public ICommand Continue => new AsyncCommand(OnContinue);

        private async Task OnContinue()
        {
            GoBackPopupCommand.Execute(null);
            await _navigation.PushModalAsync(new HomeUploadGreetingCardView());
        }
    }
}
