using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;

namespace NotForgotten.Views.Popups
{
    public partial class FinalizePopupView : PopupPage
    {
        public FinalizePopupView()
        {
            InitializeComponent();
            BindingContext = new FinalizePopupViewModel(Navigation);
        }
    }
}