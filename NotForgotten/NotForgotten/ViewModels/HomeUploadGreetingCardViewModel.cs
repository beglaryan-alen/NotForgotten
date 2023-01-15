using NotForgotten.ViewModels.HomeUploadGreetingCardDetails;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class HomeUploadGreetingCardViewModel : BaseViewModel
    {
        public HomeUploadGreetingCardViewModel(INavigation navigation) : base(navigation)
        {
            TabLabelsCollection = new ObservableCollection<string>()
            {
                "Select & Tag",
                "Bulk Upload No Tags",
            };
        }

        private ObservableCollection<string> _tabLabelsCollection;
        public ObservableCollection<string> TabLabelsCollection
        {
            get => _tabLabelsCollection;
            set => SetProperty(ref _tabLabelsCollection, value);
        }

        private ObservableCollection<BaseViewModel> _tabItems;
        public ObservableCollection<BaseViewModel> TabItems
        {
            get => _tabItems;
            set => SetProperty(ref _tabItems, value);
        }

        private BaseViewModel _currentTabItem;
        public BaseViewModel CurrentTabItem
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

        private SelectAndTagViewModel _orientationViewModel;
        public SelectAndTagViewModel OrientationViewModel
        {
            get => _orientationViewModel;
            set => SetProperty(ref _orientationViewModel, value);
        }

        private OtherFormatViewModel _otherFormatViewModel;
        public OtherFormatViewModel OtherFormatViewModel
        {
            get => _otherFormatViewModel;
            set => SetProperty(ref _otherFormatViewModel, value);
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnPropertyChanged(args);

            if (args.PropertyName == nameof(CurrentTabItem))
            {
                if (CurrentTabIndex == 0)
                    Title = "Upload  Memento";
                else if (CurrentTabIndex == 1)
                    Title = "Bulk Upload";
                else
                    throw new NotImplementedException();
            }
        }

        protected override void Initialize()
        {
            base.Initialize();

            OrientationViewModel = new SelectAndTagViewModel(_navigation);
            OrientationViewModel.GoRight = new Command(() => CurrentTabIndex = 1);

            OtherFormatViewModel = new OtherFormatViewModel(_navigation);

            TabItems = new ObservableCollection<BaseViewModel>()
            {
                OrientationViewModel,
                OtherFormatViewModel,
            };
        }
    }
}
