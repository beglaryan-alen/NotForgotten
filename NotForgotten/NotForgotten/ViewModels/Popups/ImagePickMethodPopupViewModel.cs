using MvvmHelpers.Commands;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class ImagePickMethodPopupViewModel : BasePopupViewModel
    {

        public ImagePickMethodPopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        private ICommand _photoLibrary;
        public ICommand PhotosLibrary
        {
            get => _photoLibrary;
            set => SetProperty(ref _photoLibrary, value);
        }

        private ICommand _files;
        public ICommand Files
        {
            get => _files;
            set => SetProperty(ref _files, value);
        }
    }
}
