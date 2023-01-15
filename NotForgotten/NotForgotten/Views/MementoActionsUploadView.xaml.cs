using NotForgotten.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MementoActionsUploadView : ContentPage
    {
        public MementoActionsUploadView()
        {
            InitializeComponent();
            BindingContext = new MementoActionsUploadViewModel(Navigation);
        }
    }
}