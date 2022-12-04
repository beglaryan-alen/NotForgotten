using MvvmHelpers.Commands;
using NotForgotten.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class SceneReplayViewModel : BaseViewModel
    {
        public SceneReplayViewModel(INavigation navigation) : base(navigation)
        {
        }

        public ICommand NextStep => new AsyncCommand(async() => await _navigation.PushModalAsync(new CategorizeView()));
    }
}
