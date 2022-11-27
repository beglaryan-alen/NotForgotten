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

        public static readonly BindableProperty IsTitleVisibleProperty = BindableProperty.Create(
            propertyName: nameof(IsTitleVisible),
            returnType: typeof(bool),
            declaringType: typeof(CustomNavBar));
        public bool IsTitleVisible
        {
            get => (bool)GetValue(IsTitleVisibleProperty);
            set => SetValue(IsTitleVisibleProperty, value);
        }

        public static readonly BindableProperty LeftLabelProperty = BindableProperty.Create(
            propertyName: nameof(LeftLabel),
            returnType: typeof(string),
            declaringType: typeof(CustomNavBar));
        public string LeftLabel
        {
            get => (string)GetValue(LeftLabelProperty);
            set => SetValue(LeftLabelProperty, value);
        }

        public static readonly BindableProperty IsLeftLabelVisibleProperty = BindableProperty.Create(
            propertyName: nameof(IsLeftLabelVisible),
            returnType: typeof(bool),
            declaringType: typeof(CustomNavBar));
        public bool IsLeftLabelVisible
        {
            get => (bool)GetValue(IsLeftLabelVisibleProperty);
            set => SetValue(IsLeftLabelVisibleProperty, value);
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

        public static readonly BindableProperty IsLeftIconVisibleProperty = BindableProperty.Create(
            propertyName: nameof(IsLeftIconVisible),
            returnType: typeof(bool),
            declaringType: typeof(CustomNavBar));
        public bool IsLeftIconVisible
        {
            get => (bool)GetValue(IsLeftIconVisibleProperty);
            set => SetValue(IsLeftIconVisibleProperty, value);
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

        #endregion
    }
}