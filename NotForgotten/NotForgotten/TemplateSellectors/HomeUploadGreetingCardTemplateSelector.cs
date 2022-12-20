using NotForgotten.ViewModels.HomeUploadGreetingCardDetails;
using Xamarin.Forms;

namespace NotForgotten.TemplateSellectors
{
    public class HomeUploadGreetingCardTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OrientationViewTemplate { get; set; }
        public DataTemplate OtherFormatViewTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is SelectAndTagViewModel)
                return OrientationViewTemplate;
            else
                return OtherFormatViewTemplate;
        }
    }
}
