using NotForgotten.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
	public partial class SceneReplayView : ContentPage
	{
		public SceneReplayView ()
		{
			InitializeComponent ();
			BindingContext = new SceneReplayViewModel(Navigation);

        }
	}
}