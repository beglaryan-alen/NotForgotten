using NotForgotten.ViewModels;
using Xamarin.Forms;

namespace NotForgotten.Views
{
	public partial class UploadPhotoView : ContentPage
	{
		public UploadPhotoView ()
		{
			InitializeComponent ();
			BindingContext = new UploadPhotoViewModel(Navigation);

        }
	}
}