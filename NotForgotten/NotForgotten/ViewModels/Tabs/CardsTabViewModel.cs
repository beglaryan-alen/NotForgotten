using MvvmHelpers.Commands;
using NotForgotten.Model.Cards;
using NotForgotten.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Tabs
{
    public class CardsTabViewModel : BaseTabViewModel
    {

        public CardsTabViewModel(INavigation navigation) : base(navigation)
        {
        }

        private ObservableCollection<CardsBindableModel> _collection;
        public ObservableCollection<CardsBindableModel> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        public ICommand NextCommand => new AsyncCommand(async() => await _navigation.PushModalAsync(new CategorizeView()));

        protected override void Initialize()
        {
            base.Initialize();

            Collection = new ObservableCollection<CardsBindableModel>()
            {
                new CardsBindableModel()
                {
                    Title = "Front of card",
                    Desc = "No scene recorded",
                    DownloadedSize = 2,
                    IsDownloaded= true,
                    FileSize = 2,
                },
                new CardsBindableModel()
                {
                    Title = "Inside left",
                    Desc = "Scene uploaded",
                    DownloadedSize = 1.6,
                    IsDownloaded= false,
                    FileSize = 2,
                },
                new CardsBindableModel()
                {
                    Title = "Inside right",
                    Desc = "Scene not uploaded",
                    DownloadedSize = 12.4,
                    IsDownloaded= false,
                    FileSize = 20,
                },
            };
        }
    }
}
