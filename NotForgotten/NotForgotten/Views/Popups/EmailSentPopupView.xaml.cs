using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;

namespace NotForgotten.Views.Popups
{
	public partial class EmailSentPopupView : PopupPage
    {
		public EmailSentPopupView ()
		{
			InitializeComponent ();
			BindingContext = new EmailSentPopupViewModel(Navigation);
		}
	}
}