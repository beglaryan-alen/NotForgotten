using NotForgotten.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UploadDigitalVideoView : ContentPage
    {
        public UploadDigitalVideoView()
        {
            InitializeComponent();
            BindingContext = new UploadDigitalVideoViewModel(Navigation);
        }
    }
}