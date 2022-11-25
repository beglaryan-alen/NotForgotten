using NotForgotten.Views;
using NotForgotten.Views.Popups;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

[assembly: ExportFont("NeueHaasDisplayMediu.ttf")]
[assembly: ExportFont("NeueHaasDisplayRoman.ttf")]
[assembly: ExportFont("NeueHaasDisplayBold.ttf")]
[assembly: ExportFont("SourceSansPro-Regular.ttf")]
[assembly: ExportFont("SourceSansPro-SemiBold.ttf")]
[assembly: ExportFont("SourceSansPro-Bold.ttf")]
namespace NotForgotten
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetupServices();

            MainPage = new RootView();
        }

        private void SetupServices()
        {
            DependencyService.RegisterSingleton(PopupNavigation.Instance);
        }
    }
}
