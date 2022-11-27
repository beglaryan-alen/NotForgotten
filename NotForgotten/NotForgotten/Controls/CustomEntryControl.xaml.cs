using Xamarin.Forms;

namespace NotForgotten.Controls
{
	public partial class CustomEntryControl : StackLayout
	{
		public CustomEntryControl ()
		{
			InitializeComponent();
		}

        #region -- Public properties --

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
            propertyName: nameof(Title),
            returnType: typeof(string),
            declaringType: typeof(CustomEntryControl));
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly BindableProperty TitleFontFamilyProperty = BindableProperty.Create(
            propertyName: nameof(TitleFontFamily),
            returnType: typeof(string),
            declaringType: typeof(CustomEntryControl));
        public string TitleFontFamily
        {
            get => (string)GetValue(TitleFontFamilyProperty);
            set => SetValue(TitleFontFamilyProperty, value);
        }

        public static readonly BindableProperty TitleColorProperty = BindableProperty.Create(
            propertyName: nameof(TitleColor),
            returnType: typeof(Color),
            declaringType: typeof(CustomEntryControl));
        public Color TitleColor
        {
            get => (Color)GetValue(TitleColorProperty);
            set => SetValue(TitleColorProperty, value);
        }

        public static readonly BindableProperty TitleFontSizeProperty = BindableProperty.Create(
            propertyName: nameof(TitleFontSize),
            returnType: typeof(int),
            declaringType: typeof(CustomEntryControl));
        public int TitleFontSize
        {
            get => (int)GetValue(TitleFontSizeProperty);
            set => SetValue(TitleFontSizeProperty, value);
        }

        public static readonly BindableProperty HasTitleProperty = BindableProperty.Create(
            nameof(HasTitle),
            typeof(bool),
            typeof(CustomEntryControl),
            default(bool));
        public bool HasTitle
        {
            get => (bool)GetValue(HasTitleProperty);
            set => SetValue(HasTitleProperty, value);
        }

        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(
            propertyName: nameof(IsPassword),
            returnType: typeof(bool),
            declaringType: typeof(CustomEntryControl));
        public bool IsPassword
        {
            get => (bool)GetValue(IsPasswordProperty);
            set => SetValue(IsPasswordProperty, value);
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            propertyName: nameof(Text),
            returnType: typeof(string),
            declaringType: typeof(CustomEntryControl),
            defaultBindingMode: BindingMode.TwoWay);
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
            propertyName: nameof(Placeholder),
            returnType: typeof(string),
            declaringType: typeof(CustomEntryControl));
        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public static readonly BindableProperty CustomBackgroundColorProperty = BindableProperty.Create(
            propertyName: nameof(CustomBackgroundColor),
            returnType: typeof(Color),
            declaringType: typeof(CustomEntryControl));
        public Color CustomBackgroundColor
        {
            get => (Color)GetValue(CustomBackgroundColorProperty);
            set => SetValue(CustomBackgroundColorProperty, value);
        }

        public static readonly BindableProperty PassRightIconProperty = BindableProperty.Create(
            nameof(PassRightIcon),
            typeof(string),
            typeof(CustomEntryControl),
            default(string));
        public string PassRightIcon
        {
            get => (string)GetValue(PassRightIconProperty);
            set => SetValue(PassRightIconProperty, value);
        }

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(
            nameof(FontFamily),
            typeof(string),
            typeof(CustomEntryControl),
            default(string));
        public string FontFamily
        {
            get => (string)GetValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }

        public static readonly BindableProperty IsPassRightIconVisibleProperty = BindableProperty.Create(
            nameof(IsPassRightIconVisible),
            typeof(bool),
            typeof(CustomEntryControl),
            default(bool));
        public bool IsPassRightIconVisible
        {
            get => (bool)GetValue(IsPassRightIconVisibleProperty);
            set => SetValue(IsPassRightIconVisibleProperty, value);
        }

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
            nameof(CornerRadius),
            typeof(int),
            typeof(CustomEntryControl),
            default(int));
        public int CornerRadius
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public static readonly BindableProperty HasLeftIconProperty = BindableProperty.Create(
            nameof(HasLeftIcon),
            typeof(bool),
            typeof(CustomEntryControl),
            default(bool));
        public bool HasLeftIcon
        {
            get => (bool)GetValue(HasLeftIconProperty);
            set => SetValue(HasLeftIconProperty, value);
        }

        public static readonly BindableProperty LeftIconSourceProperty = BindableProperty.Create(
            nameof(LeftIconSource),
            typeof(string),
            typeof(CustomEntryControl),
            default(string));
        public string LeftIconSource
        {
            get => (string)GetValue(LeftIconSourceProperty);
            set => SetValue(LeftIconSourceProperty, value);
        }
        #endregion

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e) =>
            IsPassword = !IsPassword;
    }
}