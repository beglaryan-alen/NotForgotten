using NotForgotten.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsUploadGreetingCardView : ContentPage
    {
        public CardsUploadGreetingCardView(int position, bool isVertical, bool isScanEnvelope = false)
        {
            InitializeComponent();
            BindingContext = new CardsUploadGreetingCardViewModel(Navigation, position, isVertical, isScanEnvelope);
        }
    }
}