using NotForgotten.Model.Categorize;
using NotForgotten.Views;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class CategorizeViewModel : BaseViewModel
    {
        public CategorizeViewModel(INavigation navigation) : base(navigation)
        {
        }

        private ObservableRangeCollection<string> _giversRelationship;
        public ObservableRangeCollection<string> GiversRelationship
        {
            get => _giversRelationship;
            set => SetProperty(ref _giversRelationship, value);
        }

        private ObservableRangeCollection<string> _occasion;
        public ObservableRangeCollection<string> Occasion
        {
            get => _occasion;
            set => SetProperty(ref _occasion, value);
        }

        private ObservableRangeCollection<string> _lifeStage;
        public ObservableRangeCollection<string> LifeStage
        {
            get => _lifeStage;
            set => SetProperty(ref _lifeStage, value);
        }

        private ObservableRangeCollection<string> _cardFormat;
        public ObservableRangeCollection<string> CardFormat
        {
            get => _cardFormat;
            set => SetProperty(ref _cardFormat, value);
        }

        public ICommand SubmitForArchive => new Command(() => App.Current.MainPage = new RootView(1));

        protected override void Initialize()
        {
            base.Initialize();
            GiversRelationship = new ObservableRangeCollection<string>()
            {
                "With me",
                "With family",
                "With other pets",
            };

            Occasion = new ObservableRangeCollection<string>()
            {
                "1st Birthday", 
                "10th Birthday",
                "Birthday",
                "Vacation",
                "Christmas",
                "Memorial",
                "Graduation",
                "Reunion",
                "Christening",
                "Bat Mitzvah",
                "Ceremony",
                "None",
            };

            LifeStage = new ObservableRangeCollection<string>()
            {
                "Baby",
                "Young Adult",
                "Adult",
                "Senior",
            };

            CardFormat = new ObservableRangeCollection<string>()
            {
                "Photo",
                "Video",
            };
        }
    }
}
