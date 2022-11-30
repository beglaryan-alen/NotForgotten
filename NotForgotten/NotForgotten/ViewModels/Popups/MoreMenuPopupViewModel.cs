using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class MoreMenuPopupViewModel : BasePopupViewModel
    {
        public MoreMenuPopupViewModel
            (
            INavigation navigation,
            int position,
            IEnumerable<BindableBase> collection) 
            : base(navigation)
        {
            Position = position;
            Collection = new ObservableCollection<BindableBase>(collection);
        }

        public int Position { get; }
        public ObservableCollection<BindableBase> Collection { get; }
    }
}
