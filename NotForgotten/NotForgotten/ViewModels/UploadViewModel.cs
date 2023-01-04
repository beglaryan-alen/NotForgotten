using NotForgotten.Model.Home;
using NotForgotten.Views;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    class UploadViewModel : BaseViewModel
    {

        public UploadViewModel
            (INavigation navigation,
            HomeBindableModel model) 
            : base(navigation)
        {
            BelongName = model.BelongName;
            Title = model.Title;
        }

        private string _belongName;
        public string BelongName
        {
            get => _belongName;
            set => SetProperty(ref _belongName, value);
        }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}
