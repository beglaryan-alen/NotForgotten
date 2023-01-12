using NotForgotten.Model.Home;
using NotForgotten.Views.Popups;
using NotForgotten.Views;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Input;
using System;
using Xamarin.Forms;
using MvvmHelpers.Commands;
using NotForgotten.Model.FreeMemorial;

namespace NotForgotten.ViewModels
{
    public class FreeMemorialViewModel : BaseViewModel
    {
        private ObservableCollection<FreeMemorialBindableModel> _collection;

        public FreeMemorialViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ObservableCollection<FreeMemorialBindableModel> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        public ICommand TapCommand => new AsyncCommand<FreeMemorialBindableModel>(OnTapCommand);
        public ICommand AcoountCommand => new AsyncCommand(OnAccountCommand);
        public ICommand StartMemorialCommand => new AsyncCommand(OnStartMemorialCommand);

        protected override void Initialize()
        {
            base.Initialize();

            Collection = new ObservableCollection<FreeMemorialBindableModel>()
            {
                new FreeMemorialBindableModel()
                {
                    Title = "Claim Your Free Memorial",
                    BelongName = "Claim your free card",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                },
            };
        }


        private async Task OnTapCommand(FreeMemorialBindableModel model)
        {
        }

        private async Task OnAccountCommand()
        {
            App.Current.MainPage = new LoginView();
        }

        private async Task OnStartMemorialCommand()
        {
            await _navigation.PushModalAsync(new WhoRememberView());
        }
    }
}
