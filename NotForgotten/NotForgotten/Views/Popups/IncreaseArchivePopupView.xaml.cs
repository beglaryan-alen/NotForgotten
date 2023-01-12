using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;

namespace NotForgotten.Views.Popups
{
	public partial class IncreaseArchivePopupView : PopupPage
    {
		public IncreaseArchivePopupView ()
		{
			InitializeComponent ();
			BindingContext = new IncreaseArchivePopupViewModel(Navigation);

        }
	}
}