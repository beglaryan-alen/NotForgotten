using NotForgotten.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeUploadGreetingCardView : ContentPage
	{
		public HomeUploadGreetingCardView()
		{
			InitializeComponent ();
			BindingContext = new HomeUploadGreetingCardViewModel(Navigation);

        }
	}
}