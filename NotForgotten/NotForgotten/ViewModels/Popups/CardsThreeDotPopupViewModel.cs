using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    internal class CardsThreeDotPopupViewModel : BasePopupViewModel
    {
        public CardsThreeDotPopupViewModel(
            INavigation navigation,
            int position) : base(navigation)
        {
            Position = position;
        }

        public ICommand ViewCommand => new AsyncCommand(OnViewCommand);

        public ICommand DeleteCommand { get; set; }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value);
        }

        private async Task OnViewCommand()
        {
            GoBackCommand.Execute(null);
            await _navigation.PushModalAsync(new UploadView(new Model.Home.HomeBindableModel
            {
                 BelongName = "Archie",
                 Title="Handdrawn Mothers Day",
            }));
        }
    }
}
