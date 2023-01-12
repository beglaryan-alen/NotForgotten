using MvvmHelpers.Commands;
using NotForgotten.Views.Popups;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class UploadPhotoViewModel : BaseViewModel
    {
        public UploadPhotoViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand Upload => new AsyncCommand(async () => await _popupNavigation.PushAsync(new CardNamePopupView()));
    }
}
