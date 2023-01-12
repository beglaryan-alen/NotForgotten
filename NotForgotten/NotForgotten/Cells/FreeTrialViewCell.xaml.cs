using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.Cells
{
	public partial class FreeTrialViewCell : Grid
    {
		public FreeTrialViewCell ()
		{
			InitializeComponent ();
		}

        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create(
            propertyName: nameof(TapCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(FreeTrialViewCell));
        public ICommand TapCommand
        {
            get => (ICommand)GetValue(TapCommandProperty);
            set => SetValue(TapCommandProperty, value);
        }
    }
}