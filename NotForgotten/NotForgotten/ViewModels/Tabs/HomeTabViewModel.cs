using MvvmHelpers.Commands;
using NotForgotten.Model.Cards;
using NotForgotten.Model.Home;
using NotForgotten.Views;
using NotForgotten.Views.Popups;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Tabs
{
    public class HomeTabViewModel : BaseTabViewModel
    {
        public HomeTabViewModel(INavigation navigation) : base(navigation)
        {
        }

        private ObservableCollection<HomeBindableModel> _collection;
        public ObservableCollection<HomeBindableModel> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        public ICommand IndexToLibrary => new AsyncCommand(async () => await _popupNavigation.PushAsync(new FinalizePopupView()));
        public ICommand AddAnother => new AsyncCommand(async () => await _popupNavigation.PushAsync(new CardNamePopupView()));
        public ICommand TapCommand => new AsyncCommand<HomeBindableModel>(OnTapCommand);

        protected override void Initialize()
        {
            base.Initialize();

            Collection = new ObservableCollection<HomeBindableModel>()
            {
                new HomeBindableModel()
                {
                    Title = "Birthday card skiing",
                    BelongName = "Sally Field",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    IsDownloaded = true,
                    IsFavorite = true,
                    DownloadedSize = 2,
                    FileSize = 2,
                },
                new HomeBindableModel()
                {
                    Title = "Video Card from Mom",
                    BelongName = "Mom",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    DownloadedSize = 1.6,
                    FileSize = 2,
                },
                new HomeBindableModel()
                {
                    Title = "Handdrawn mothers day",
                    BelongName = "Archie",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    IsFavorite = true,
                    IsDownloaded = true,
                },
                new HomeBindableModel()
                {
                    Title = "My First Product",
                    BelongName = "Individual Archive",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    IsDownloaded = true,
                },
            };
        }


        private async Task OnTapCommand(HomeBindableModel model)
        {
            if (model != null)
            {
                await _navigation.PushModalAsync(new HomeUploadView(model));
            }
        }
    }
}
