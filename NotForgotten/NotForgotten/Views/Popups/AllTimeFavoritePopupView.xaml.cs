using NotForgotten.ViewModels.Popups;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views.Popups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllTimeFavoritePopupView : PopupPage
	{
		public AllTimeFavoritePopupView ()
		{
			InitializeComponent ();
			BindingContext = new AllTimeFavoritePopupViewModel(Navigation);
        }
	}
}