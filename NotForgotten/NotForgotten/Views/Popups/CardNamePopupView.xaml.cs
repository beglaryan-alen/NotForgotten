using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views.Popups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardNamePopupView : PopupPage
	{
		public CardNamePopupView ()
		{
			InitializeComponent ();
			BindingContext = new CardNamePopupViewModel(Navigation);

        }
	}
}