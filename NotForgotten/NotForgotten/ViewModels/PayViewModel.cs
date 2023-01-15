using NotForgotten.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class PayViewModel : BaseViewModel
    {
        public PayViewModel
            (INavigation navigation) 
            : base(navigation)
        {
        }

        public ICommand Pay => new Command(async () => await _navigation.PushModalAsync(new MementoActionsUploadView()));
    }
}
