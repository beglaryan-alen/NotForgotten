using NotForgotten.ViewModels.Tabs;
using NotForgotten.ViewModels.UploadGreetingCardDetails;
using Xamarin.Forms;

namespace NotForgotten.TemplateSellectors
{
    public class UploadGreetingCardTemplateSelector : DataTemplateSelector
    {
        public DataTemplate OrientationViewTemplate { get; set; }
        public DataTemplate OtherFormatViewTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is OrientationViewModel)
                return OrientationViewTemplate;
            else
                return OtherFormatViewTemplate;
        }
    }
}
