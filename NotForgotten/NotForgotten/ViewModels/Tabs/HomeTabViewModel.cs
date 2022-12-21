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
        private readonly RootView rootView;
        public HomeTabViewModel(INavigation navigation,
            RootView rootView) : base(navigation)
        {
            this.rootView = rootView;
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
        public ICommand SwipeCommand => new AsyncCommand<HomeBindableModel>(OnSwipeCommand);
        public ICommand SettingsCommand => new AsyncCommand<HomeBindableModel>(OnSettingsCommand);

        protected override void Initialize()
        {
            base.Initialize();

            Collection = new ObservableCollection<HomeBindableModel>()
            {
                new HomeBindableModel()
                {
                    Title = "Grandpa and I at Disney",
                    BelongName = "Video",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    IsDownloaded = true,
                    IsFavorite = true,
                    DownloadedSize = 2,
                    FileSize = 2,
                },
                new HomeBindableModel()
                {
                    Title = "Poppa and Grandma’s Wedding",
                    BelongName = "Video",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    DownloadedSize = 1.6,
                    FileSize = 2,
                },
                new HomeBindableModel()
                {
                    Title = "Dad’s birth",
                    BelongName = "Photo",
                    Date = DateTime.ParseExact("27/05/2020", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                    DownloadedSize = 2,
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
                await _navigation.PushModalAsync(new UploadView(model, rootView));
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
