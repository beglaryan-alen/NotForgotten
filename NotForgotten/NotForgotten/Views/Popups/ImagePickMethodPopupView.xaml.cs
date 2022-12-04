using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;

namespace NotForgotten.Views.Popups
{
	public partial class ImagePickMethodPopupView : PopupPage
	{
		public ImagePickMethodPopupView ()
		{
			InitializeComponent ();
			BindingContext = new ImagePickMethodPopupViewModel(Navigation);

        }
	}
}