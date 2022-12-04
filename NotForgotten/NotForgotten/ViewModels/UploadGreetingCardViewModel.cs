﻿using NotForgotten.ViewModels.Popups;
using NotForgotten.ViewModels.Tabs;
using NotForgotten.ViewModels.UploadGreetingCardDetails;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class UploadGreetingCardViewModel : BaseViewModel
    {
        public UploadGreetingCardViewModel(INavigation navigation) : base(navigation)
        {
            TabLabelsCollection = new ObservableCollection<string>()
            {
                "Orientation",
                "Other Format",
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

        private OrientationViewModel _orientationViewModel;
        public OrientationViewModel OrientationViewModel
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

        protected override void Initialize()
        {
            base.Initialize();

            OrientationViewModel = new OrientationViewModel(_navigation);

            OtherFormatViewModel = new OtherFormatViewModel(_navigation);

            TabItems = new ObservableCollection<BaseViewModel>()
            {
                OrientationViewModel,
                OtherFormatViewModel,
            };
        }
    }
}
