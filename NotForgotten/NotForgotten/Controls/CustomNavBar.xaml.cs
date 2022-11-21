using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.Controls
{
    public partial class CustomNavBar : Grid
    {
        public CustomNavBar()
        {
            InitializeComponent();
        }

        #region -- Public properties --

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
            propertyName: nameof(Title),
            returnType: typeof(string),
            declaringType: typeof(CustomNavBar));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly BindableProperty LeftIconProperty = BindableProperty.Create(
            propertyName: nameof(LeftIcon),
            returnType: typeof(string),
            declaringType: typeof(CustomNavBar));

        public string LeftIcon
        {
            get => (string)GetValue(LeftIconProperty);
            set => SetValue(LeftIconProperty, value);
        }

        public static readonly BindableProperty RightIconProperty = BindableProperty.Create(
            nameof(RightIcon),
            typeof(string),
            typeof(CustomNavBar),
            default(string));

        public string RightIcon
        {
            get => (string)GetValue(RightIconProperty);
            set => SetValue(RightIconProperty, value);
        }

        public static readonly BindableProperty IsRightIconVisibleProperty = BindableProperty.Create(
            nameof(IsRightIconVisible),
            typeof(bool),
            typeof(CustomNavBar),
            default(bool));

        public bool IsRightIconVisible
        {
            get => (bool)GetValue(IsRightIconVisibleProperty);
            set => SetValue(IsRightIconVisibleProperty, value);
        }

        public static readonly BindableProperty RightLabelTextProperty = BindableProperty.Create(
            propertyName: nameof(RightLabelText),
            returnType: typeof(string),
            declaringType: typeof(CustomNavBar));

        public string RightLabelText
        {
            get => (string)GetValue(RightLabelTextProperty);
            set => SetValue(RightLabelTextProperty, value);
        }

        public static readonly BindableProperty IsRightLabelVisibleProperty = BindableProperty.Create(
            nameof(IsRightLabelVisible),
            typeof(bool),
            typeof(CustomNavBar),
            default(bool));

        public bool IsRightLabelVisible
        {
            get => (bool)GetValue(IsRightLabelVisibleProperty);
            set => SetValue(IsRightLabelVisibleProperty, value);
        }

        public static readonly BindableProperty LeftIconTapCommandProperty = BindableProperty.Create(
            propertyName: nameof(LeftIconTapCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(CustomNavBar));

        public ICommand LeftIconTapCommand
        {
            get => (ICommand)GetValue(LeftIconTapCommandProperty);
            set => SetValue(LeftIconTapCommandProperty, value);
        }

        public static readonly BindableProperty RightIconTapCommandProperty = BindableProperty.Create(
            propertyName: nameof(RightIconTapCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(CustomNavBar));

        public ICommand RightIconTapCommand
        {
            get => (ICommand)GetValue(RightIconTapCommandProperty);
            set => SetValue(RightIconTapCommandProperty, value);
        }

        #endregion
    }
}