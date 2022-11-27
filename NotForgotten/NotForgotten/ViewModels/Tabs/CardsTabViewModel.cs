using NotForgotten.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
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
                    DownloadedSize = 10,
                    IsDownloaded= false,
                    FileSize = 200,
                },
                new CardsBindableModel()
                {
                    Title = "Inside right",
                    Desc = "Scene not uploaded",
                    DownloadedSize = 0,
                    IsDownloaded= false,
                    FileSize = 20,
                },
            };

            Task.Run(async() =>
            {
                while (true)
                {
                    Collection[1].DownloadedSize += 0.1;
                    if (Collection[1].DownloadedSize.CompareTo(Collection[1].FileSize) >= 0)
                    {
                        Collection[1].IsDownloaded = true;
                        return;
                    }
                    await Task.Delay(500);
                }
                
            });

            Task.Run(async () =>
            {
                while (true)
                {
                    Collection[2].DownloadedSize += 0.1;
                    if (Collection[2].DownloadedSize.CompareTo(Collection[2].FileSize) >= 0)
                    {
                        Collection[2].IsDownloaded = true;
                        return;
                    }
                    await Task.Delay(400);
                }
                
            });
        }
    }
}
