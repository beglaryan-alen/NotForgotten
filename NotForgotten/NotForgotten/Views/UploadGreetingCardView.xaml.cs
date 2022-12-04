using NotForgotten.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UploadGreetingCardView : ContentPage
	{
		public UploadGreetingCardView ()
		{
			InitializeComponent ();
			BindingContext = new UploadGreetingCardViewModel(Navigation);

        }
	}
}