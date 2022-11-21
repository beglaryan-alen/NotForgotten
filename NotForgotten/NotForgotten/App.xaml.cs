using NotForgotten.Views;
using NotForgotten.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

[assembly: ExportFont("NeueHaasDisplayMediu.ttf", Alias = "big")]
[assembly: ExportFont("NeueHaasDisplayRoman.ttf", Alias = "normal")]
[assembly: ExportFont("NeueHaasDisplayBold.ttf", Alias = "bold")]
[assembly: ExportFont("SourceSansPro-Regular.ttf", Alias = "regular")]
[assembly: ExportFont("SourceSansPro-SemiBold.ttf", Alias = "semibold")]
[assembly: ExportFont("SourceSansPro-Bold.ttf")]
namespace NotForgotten
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetupServices();

            MainPage = new LoginView();
        }

        private void SetupServices()
        {
            DependencyService.RegisterSingleton(PopupNavigation.Instance);
        }
    }
}
