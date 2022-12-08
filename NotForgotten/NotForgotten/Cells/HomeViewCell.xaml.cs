using NotForgotten.Controls;
using NotForgotten.Views.Popups;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace NotForgotten.Cells
{
    public partial class HomeViewCell : Grid
    {
        public HomeViewCell()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(
            propertyName: nameof(TapCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(HomeViewCell));
        public ICommand TapCommand
        {
            get => (ICommand)GetValue(TapCommandProperty);
            set => SetValue(TapCommandProperty, value);
        }

        public static readonly BindableProperty SettingsCommandProperty = BindableProperty.Create(
            propertyName: nameof(SettingsCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(HomeViewCell));
        public ICommand SettingsCommand
        {
            get => (ICommand)GetValue(SettingsCommandProperty);
            set => SetValue(SettingsCommandProperty, value);
        }
    }
}