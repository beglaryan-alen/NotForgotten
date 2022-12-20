using Prism.Mvvm;

namespace NotForgotten.Model.HomeUploadGreetingCard
{
    public class SelectAndTagBindableModel : BindableBase
    {
        private string _image;
        public string Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }

        private string _type;
        public string Type
        {
            get => _type;
            set => SetProperty(ref _type, value);
        }
    }
}
