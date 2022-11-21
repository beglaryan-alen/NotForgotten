using Xamarin.Forms;

namespace NotForgotten.Controls
{
	public partial class CheckboxControl : Image
	{
		public CheckboxControl ()
		{
			InitializeComponent();
		}

        public static readonly BindableProperty IsClickedProperty = BindableProperty.Create(
             propertyName: nameof(IsClicked),
             returnType: typeof(bool),
             declaringType: typeof(CheckboxControl));
        public bool IsClicked
        {
            get => (bool)GetValue(IsClickedProperty);
            set => SetValue(IsClickedProperty, value);
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            IsClicked = !IsClicked;
            if (IsClicked)
                image.Source = "checkbox_clicked";
            else
                image.Source = "checkbox_circle";
        }
    }
}