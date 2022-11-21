using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;

namespace NotForgotten.Views.Popups
{
	public partial class RegisterPopupView : PopupPage
    {
		public RegisterPopupView ()
		{
			InitializeComponent ();
			BindingContext = new RegisterPopupViewModel(Navigation);
		}
	}
}