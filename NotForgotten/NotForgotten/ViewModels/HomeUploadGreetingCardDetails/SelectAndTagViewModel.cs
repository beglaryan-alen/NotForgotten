using MvvmHelpers;
using MvvmHelpers.Commands;
using NotForgotten.Model.HomeUploadGreetingCard;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.HomeUploadGreetingCardDetails
{
    public class SelectAndTagViewModel : BaseViewModel
    {
        public SelectAndTagViewModel(INavigation navigation) : base(navigation)
        {
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
                if (model.Type.ToLower() == "Video".ToLower())
                {
                    await Xamarin.Essentials.MediaPicker.PickVideoAsync();
                }
                else if (model.Type.ToLower() == "Photo".ToLower())
                {
                    await Xamarin.Essentials.MediaPicker.PickPhotoAsync();
                }
                else if (model.Type.ToLower() == "Document or File".ToLower())
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
                    Type = "Video",
                },
                new SelectAndTagBindableModel()
                {
                    Image = "ibm_product",
                    Type = "Photo",
                },
                new SelectAndTagBindableModel()
                {
                    Image = "ibm_product",
                    Type = "Document or File",
                },
            };
        }

        #endregion


    }
}
