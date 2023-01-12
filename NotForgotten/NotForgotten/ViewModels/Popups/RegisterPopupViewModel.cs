using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class RegisterPopupViewModel : BasePopupViewModel
    {
        public RegisterPopupViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand RegisterCommand => new AsyncCommand(OnRegisterCommand);

        private async Task OnRegisterCommand()
        {
            //GoBackPopupCommand.Execute(null);
            //var rootView = new RootView(1);
            //App.Current.MainPage = rootView;
            //await Task.Delay(500);
            //await rootView.Navigation.PushModalAsync(new WhoRememberView(), true);

            var res = await Xamarin.Essentials.MediaPicker.CapturePhotoAsync();
            if (res != null)
            {
                GoBackCommand.Execute(null);
                await _navigation.PushModalAsync(new UploadPhotoView());

            }
        }
    }
}
