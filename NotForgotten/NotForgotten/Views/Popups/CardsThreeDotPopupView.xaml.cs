using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace NotForgotten.Views.Popups
{
    public partial class CardsThreeDotPopupView : PopupPage
    {
        private readonly CardsThreeDotPopupViewModel _vm;

        public CardsThreeDotPopupView(int position)
        {
            InitializeComponent();
            BindingContext = _vm =new CardsThreeDotPopupViewModel(Navigation, position);
            SetRightPosition();
        }

        private void SetRightPosition()
        {
            int rightPosition = 100;
            for (int i = 0; i < _vm.Position; i++)
            {
                rightPosition += 50;
            }
            settings.Margin = new Xamarin.Forms.Thickness(0, rightPosition, 0, 0);
        }
    }
}