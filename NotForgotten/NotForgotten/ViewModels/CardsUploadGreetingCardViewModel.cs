using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class CardsUploadGreetingCardViewModel : BaseViewModel
    {
        public CardsUploadGreetingCardViewModel
            (INavigation navigation,
            int position,
            bool isVertical) 
            : base(navigation)
        {
            TabLabelsCollection = new ObservableCollection<string>()
            {
                "Front",
                "Inside Left",
                "Inside Right"
            };
            CurrentTabIndex = position;
            IsVertical = isVertical;
        }

        private ObservableCollection<string> _tabLabelsCollection;
        public ObservableCollection<string> TabLabelsCollection
        {
            get => _tabLabelsCollection;
            set => SetProperty(ref _tabLabelsCollection, value);
        }

        private int _currentTabIndex;
        public int CurrentTabIndex
        {
            get => _currentTabIndex;
            set =>SetProperty(ref _currentTabIndex, value);
        }

        private bool _isVertical;
        public bool IsVertical
        {
            get => _isVertical;
            set => SetProperty(ref _isVertical, value);
        }
    }
}
