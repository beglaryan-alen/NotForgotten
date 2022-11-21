using NotForgotten.ViewModels;
using Xamarin.Forms;

namespace NotForgotten.Views
{
	public partial class ResetPasswordView : ContentPage
	{
		public ResetPasswordView ()
		{
			InitializeComponent ();
			BindingContext = new ResetPasswordViewModel(Navigation);
		}
	}
}