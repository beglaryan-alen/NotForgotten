using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;
using System;

namespace NotForgotten.Views.Popups
{
    public partial class HomeThreeDotPopupView : PopupPage
    {
        private readonly HomeThreeDotPopupViewModel _vm;
        public HomeThreeDotPopupView(int position)
        {
            InitializeComponent();
            BindingContext = _vm = new HomeThreeDotPopupViewModel(Navigation, position);
            SetRightPosition();
        }

        private void SetRightPosition()
        {
            int rightPosition = 100;
            for (int i = 0; i < _vm.Position; i++)
            {
                rightPosition += 80;
            }
            settings.Margin = new Xamarin.Forms.Thickness(0, rightPosition, 0, 0);
        }
    }
}