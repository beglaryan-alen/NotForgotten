using NotForgotten.ViewModels.Tabs;
using NotForgotten.Views.Tabs;
using Xamarin.Forms;

namespace NotForgotten.TemplateSellectors
{
    public class TabTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CardsTabTemplate { get; set; }
        public DataTemplate HomeTabTemplate { get; set; }
        public DataTemplate SettingsTabTemplate { get; set; }
        public DataTemplate ShopTabTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container) 
        {
            if (item is CardsTabViewModel)
                return CardsTabTemplate;
            else if (item is HomeTabViewModel)
                return HomeTabTemplate;
            else if (item is SettingsTabViewModel)
                return SettingsTabTemplate;
            else
                return ShopTabTemplate;
        }
    }
}
