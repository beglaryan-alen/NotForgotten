using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class HomeThreeDotPopupViewModel : BasePopupViewModel
    {
        public HomeThreeDotPopupViewModel(
            INavigation navigation,
            int menuPosition) : base(navigation)
        {
            Position = menuPosition;
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
            GoBackPopupCommand.Execute(null);
            await _navigation.PushModalAsync(new UploadView(new Model.Home.HomeBindableModel()
            {
                BelongName= "From Archie",
                Title = "Handdrawn Mothers Day",
            }));
        }

    }
}
