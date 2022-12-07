using NotForgotten.ViewModels.Tabs;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class RootViewModel : BaseViewModel
    {
        private readonly bool _isCardsScreenShotVertical;
        public RootViewModel(
            INavigation navigation, 
            int position,
            bool isCardsScreenShotVertical) 
            : base(navigation)
        {
            TabLabelsCollection = new ObservableCollection<string>()
            {
                "Cards",
                "Home",
                "Shop",
                "Settings",
            };
            TabIconsCollection = new ObservableCollection<string>()
            {
                "cards_icon",
                "home_icon",
                "shop_icon",
                "settings_icon",
            };
            CurrentTabIndex = position;
            _isCardsScreenShotVertical = isCardsScreenShotVertical;
            SetViewModels();
        }

        

        private ObservableCollection<string> _tabLabelsCollection;
        public ObservableCollection<string> TabLabelsCollection
        {
            get => _tabLabelsCollection;
            set => SetProperty(ref _tabLabelsCollection, value);
        }

        private ObservableCollection<string> _tabIconsCollection;
        public ObservableCollection<string> TabIconsCollection
        {
            get => _tabIconsCollection;
            set => SetProperty(ref _tabIconsCollection, value);
        }

        private ObservableCollection<BaseTabViewModel> _tabItems;
        public ObservableCollection<BaseTabViewModel> TabItems
        {
            get => _tabItems;
            set => SetProperty(ref _tabItems, value);
        }

        private BaseTabViewModel _currentTabItem;
        public BaseTabViewModel CurrentTabItem
        {
            get => _currentTabItem;
            set => SetProperty(ref _currentTabItem, value);
        }

        private int _currentTabIndex;
        public int CurrentTabIndex
        {
            get => _currentTabIndex;
            set
            {
                SetProperty(ref _currentTabIndex, value);

                if (TabItems != null)
                {
                    CurrentTabItem = TabItems[_currentTabIndex];
                }
            }
        }

        private CardsTabViewModel _cardsTabViewModel;
        public CardsTabViewModel CardsTabViewModel
        {
            get => _cardsTabViewModel;
            set => SetProperty(ref _cardsTabViewModel, value);
        }

        private HomeTabViewModel _homeTabViewModel;
        public HomeTabViewModel HomeTabViewModel
        {
            get => _homeTabViewModel;
            set => SetProperty(ref _homeTabViewModel, value);
        }

        private SettingsTabViewModel _settingsTabVIewModel;
        public SettingsTabViewModel SettingsTabVIewModel
        {
            get => _settingsTabVIewModel;
            set => SetProperty(ref _settingsTabVIewModel, value);
        }

        private ShopTabViewModel _shopTabViewModel;
        public ShopTabViewModel ShopTabViewModel
        {
            get => _shopTabViewModel;
            set => SetProperty(ref _shopTabViewModel, value);
        }

        #region -- Overrides --

        private void SetViewModels()
        {
            CardsTabViewModel = new CardsTabViewModel(_navigation, _isCardsScreenShotVertical);

            HomeTabViewModel = new HomeTabViewModel(_navigation);

            ShopTabViewModel = new ShopTabViewModel(_navigation);

            SettingsTabVIewModel = new SettingsTabViewModel(_navigation);


            TabItems = new ObservableCollection<BaseTabViewModel>()
            {
                CardsTabViewModel,
                HomeTabViewModel,
                ShopTabViewModel,
                SettingsTabVIewModel,
            };
        }

        #endregion
    }
}
