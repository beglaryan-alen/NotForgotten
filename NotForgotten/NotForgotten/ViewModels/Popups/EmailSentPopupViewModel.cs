using MvvmHelpers.Commands;
using NotForgotten.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels.Popups
{
    public class EmailSentPopupViewModel : BasePopupViewModel
    {
        public EmailSentPopupViewModel(INavigation navigation) : base(navigation)
        {
        }

         public ICommand DoneCommand => new AsyncCommand(OnDoneCommand);

        private async Task OnDoneCommand()
        {
            GoBackPopupCommand.Execute(null);
            var rootView = new RootView(1);
            App.Current.MainPage = rootView;
            await rootView.Navigation.PushModalAsync(new SettingsView());
        }
    }
}
