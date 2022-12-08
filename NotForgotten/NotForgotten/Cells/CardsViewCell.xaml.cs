using NotForgotten.Controls;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.Cells
{
    public partial class CardsViewCell : Frame
    {
        public CardsViewCell()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(
            propertyName: nameof(TapCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(CardsViewCell));
        public ICommand TapCommand
        {
            get => (ICommand)GetValue(TapCommandProperty);
            set => SetValue(TapCommandProperty, value);
        }

        public static readonly BindableProperty SettingsCommandProperty = BindableProperty.Create(
            propertyName: nameof(SettingsCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(CardsViewCell));
        public ICommand SettingsCommand
        {
            get => (ICommand)GetValue(SettingsCommandProperty);
            set => SetValue(SettingsCommandProperty, value);
        }
    }
}