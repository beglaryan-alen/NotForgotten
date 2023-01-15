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
        public HomeTabViewModel(INavigation navigation) 
            : base(navigation)
        {
        }

        private ObservableCollection<HomeBindableModel> _collection;
        public ObservableCollection<HomeBindableModel> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        public ICommand IndexToLibrary => new AsyncCommand(async () => await _popupNavigation.PushAsync(new FinalizePopupView()));
        public ICommand AddAnother => new AsyncCommand(async () => await _popupNavigation.PushAsync(new IncreaseArchivePopupView()));
        public ICommand TapCommand => new AsyncCommand<HomeBindableModel>(OnTapCommand);
        public ICommand SwipeCommand => new AsyncCommand<HomeBindableModel>(OnSwipeCommand);
        public ICommand SettingsCommand => new AsyncCommand<HomeBindableModel>(OnSettingsCommand);

        protected override void Initialize()
        {
            base.Initialize();

            Collection = new ObservableCollection<HomeBindableModel>()
            {
                new HomeBindableModel()
                {
                    Title = "Fido as a puppy",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    IsDownloaded = true,
                    IsFavorite = true,
                    BelongName="Video",
                    DownloadedSize = 2,
                    FileSize = 2,
                },
                new HomeBindableModel()
                {
                    Title = "Fido playing with Billy",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    DownloadedSize = 1.6,
                    BelongName="Video",
                    FileSize = 2,
                },
                new HomeBindableModel()
                {
                    Title = "Best photo ever of Fido",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    DownloadedSize = 2,
                    BelongName="Photo",
                    IsDownloaded = true,
                    IsFavorite = true,  
                    FileSize = 2,
                },
                new HomeBindableModel()
                {
                    Title = "My First Product",
                    BelongName = "Individual Archive",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    DownloadedSize = 2,
                    IsDownloaded = true,
                    FileSize = 2,
                },
            };
        }


        private async Task OnTapCommand(HomeBindableModel model)
        {
            if (model != null)
            {
                await _navigation.PushModalAsync(new UploadView(model));
            }
        }

        private async Task OnSwipeCommand(HomeBindableModel model)
        {
            if (model != null)
            {
                await _popupNavigation.PushAsync(new CardNamePopupView());
            }
        }

        private async Task OnSettingsCommand(HomeBindableModel model)
        {
            if (model != null)
            {
                await _popupNavigation.PushAsync(new HomeThreeDotPopupView(Collection.IndexOf(model)));
            }
        }
    }
}
