using MvvmHelpers;
using MvvmHelpers.Commands;
using NotForgotten.Model.HomeUploadGreetingCard;
using NotForgotten.Views;
using NotForgotten.Views.Popups;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class MementoActionsUploadViewModel : BaseViewModel
    {
        public MementoActionsUploadViewModel(INavigation navigation) : base(navigation)
        {
            Title = "Memento Actions";
        }

        #region -- Public Properties --

        private ObservableRangeCollection<SelectAndTagBindableModel> _collection;
        public ObservableRangeCollection<SelectAndTagBindableModel> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        public ICommand TapCommand => new AsyncCommand<SelectAndTagBindableModel>(OnTapCommand);
        public ICommand GoRight { get; set; }

        private async Task OnTapCommand(SelectAndTagBindableModel model)
        {
            if (model != null)
            {
                if (model.Type.ToLower() == "Upload and tag a video memory".ToLower())
                {
                    var uploadDigitalAssetsView = new UploadDigitalAssetsView(true);
                    await _navigation.PushModalAsync(uploadDigitalAssetsView);
                    (uploadDigitalAssetsView.BindingContext as UploadDigitalAssetsViewModel).UploadCommand.Execute(null);
                }
                else if (model.Type.ToLower() == "Upload and tag a photo".ToLower())
                {
                    var res = await Xamarin.Essentials.MediaPicker.CapturePhotoAsync();
                    if (res != null)
                    {
                        await _navigation.PushModalAsync(new UploadPhotoView());
                    }
                }
                else if (model.Type.ToLower() == "Upload a document  or file".ToLower())
                {
                    await _navigation.PushModalAsync(new UploadDigitalAssetsView());
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        #endregion

        #region -- Overrides --

        protected override void Initialize()
        {
            base.Initialize();

            Collection = new ObservableRangeCollection<SelectAndTagBindableModel>()
            {
                new SelectAndTagBindableModel()
                {
                    Image = "ibm_product",
                    Type = "Upload and tag a video memory",
                },
                new SelectAndTagBindableModel()
                {
                    Image = "ibm_product",
                    Type = "Upload and tag a photo",
                },
                new SelectAndTagBindableModel()
                {
                    Image = "ibm_product",
                    Type = "Upload a document  or file",
                },
            };
        }

        #endregion
    }
}
