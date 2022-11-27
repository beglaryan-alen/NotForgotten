using NotForgotten.Model.Categorize;
using System.Collections.Generic;
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


        protected override void Initialize()
        {
            base.Initialize();
            GiversRelationship = new ObservableRangeCollection<string>()
            {
                        "Boyfriend",
                        "Husband",
                        "Wife",
                        "Spouse",
                        "Child",
                        "Family",
                        "Father",
                        "Friend",
                        "GrandParent",
                        "Mother",
                        "Colleague",
                        "Other",
            };

            Occasion = new ObservableRangeCollection<string>()
            {
                "1st Birthday",
                        "10th Birthday",
                        "13th Birthday",
                        "21st Birthday",
                        "30th Birthday",
                        "40th Birthday",
                        "50th Birthday",
                        "60th Birthday",
                        "Birthday",
                        "Christmas",
                        "Congratulations",
                        "Easter",
                        "Fathers Day",
                        "Get Well",
                        "Graduation",
                        "High school Graduation",
                        "Mother day",
                        "New Baby",
                        "No reason",
                        "Sympathy",
                        "Thank you",
                        "Thanksgiving",
                        "Thinking of you",
                        "Valentines Day",
                        "Wedding",
            };

            LifeStage = new ObservableRangeCollection<string>()
            {
                "Baby",
                        "Child",
                        "Teen",
                        "Young Adult",
                        "Senior",
                        "General"
            };

            CardFormat = new ObservableRangeCollection<string>()
            {
                "Card",
                "Postcard",
                "Letter",
                "Text",
                "Video",
                "Voicemail",
            };
        }
    }
}
