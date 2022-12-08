using MvvmHelpers.Commands;
using NotForgotten.Model.Cards;
using NotForgotten.ViewModels.Popups;
using NotForgotten.Views;
using NotForgotten.Views.Popups;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Tabs
{
    public class CardsTabViewModel : BaseTabViewModel
    {
        private readonly bool _isVertical;
        public CardsTabViewModel(
            INavigation navigation,
            bool isVertical) 
            : base(navigation)
        {
            _isVertical = isVertical;
        }

        private ObservableCollection<CardsBindableModel> _collection;
        public ObservableCollection<CardsBindableModel> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        public ICommand NextCommand => new AsyncCommand(async() => await _navigation.PushModalAsync(new CategorizeView()));
        public ICommand TapCommand => new AsyncCommand<CardsBindableModel>(OnTapCommand);
        public ICommand SettingsCommand => new AsyncCommand<CardsBindableModel>(OnSettingsCommand);

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
                new CardsBindableModel()
                {
                    Title = "Envelope",
                    Desc = "No scene recorded",
                    HasSettings = true,
                },
            };
        }

        private async Task OnTapCommand(CardsBindableModel model)
        {
            if (model != null)
            {
                if (model.Title.ToLower() == "front of card")
                {
                    await _navigation.PushModalAsync(new CardsUploadGreetingCardView(0, _isVertical));
                }
                else if(model.Title.ToLower() == "inside left")
                {
                    await _navigation.PushModalAsync(new CardsUploadGreetingCardView(1, _isVertical));
                }
                else if(model.Title.ToLower() == "inside right")
                {
                    await _navigation.PushModalAsync(new CardsUploadGreetingCardView(2, _isVertical));
                }
                else if (model.Title.ToLower() == "envelope")
                {
                    await _navigation.PushModalAsync(new CardsUploadGreetingCardView(2, _isVertical, true));
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }
        }

        private async Task OnSettingsCommand(CardsBindableModel model)
        {
            if (model != null)
            {
                await _popupNavigation.PushAsync(new CardsThreeDotPopupView(Collection.IndexOf(model)));
            }
        }

    }
}
