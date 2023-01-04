﻿using MvvmHelpers.Commands;
using NotForgotten.Model.OtherFormat;
using NotForgotten.ViewModels.Popups;
using NotForgotten.Views;
using NotForgotten.Views.Popups;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class UploadDigitalVideoViewModel : BaseViewModel
    {
        public UploadDigitalVideoViewModel(INavigation navigation) : base(navigation)
        {
            Collection = new ObservableCollection<OtherFormatBindableModel>();
        }

        private ObservableCollection<OtherFormatBindableModel> _collection;
        public ObservableCollection<OtherFormatBindableModel> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        public ICommand UploadCommand => new AsyncCommand(OnUploadCommand);
        public ICommand SaveCommand => new AsyncCommand(OnSaveCommand);


        private Task OnSaveCommand()
        {
            return _navigation.PushModalAsync(new SceneReplayView());
        }


        private async Task OnUploadCommand()
        {
            //TODO: Remake this shit
            var view = new ImagePickMethodPopupView();
            var viewModel = view.BindingContext as ImagePickMethodPopupViewModel;
            viewModel.PhotosLibrary = new AsyncCommand(OnPhotoLibraryCommand);
            viewModel.Files = new AsyncCommand(FilesCommand);
            await _popupNavigation.PushAsync(view);
        }

        private async Task FilesCommand()
        {
            var res = await Xamarin.Essentials.MediaPicker.PickPhotoAsync();
            if (res != null)
            {
                Collection.Add(new OtherFormatBindableModel()
                {
                    Title = "File name",
                    FileSize = 2,
                    DownloadedSize = 1.6,
                    IsDownloaded = false,
                });
            }

            await _popupNavigation.PopAsync();
        }

        private async Task OnPhotoLibraryCommand()
        {
            var res = await Xamarin.Essentials.MediaPicker.CapturePhotoAsync();
            if (res != null)
            {
                Collection.Add(new OtherFormatBindableModel()
                {
                    Title = "File name",
                    FileSize = 2,
                    DownloadedSize = 1.6,
                    IsDownloaded = false,
                });
            }
            await _popupNavigation.PopAsync();
        }
    }
}
