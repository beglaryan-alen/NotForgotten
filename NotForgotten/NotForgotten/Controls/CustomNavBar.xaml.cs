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

        public static readonly BindableProperty RightIconProperty = BindableProperty.Create(
            propertyName: nameof(RightIcon),
            returnType: typeof(string),
            declaringType: typeof(CustomNavBar));
        public string RightIcon
        {
            get => (string)GetValue(RightIconProperty);
            set => SetValue(RightIconProperty, value);
        }

        public static readonly BindableProperty IsRightIconVisibleProperty = BindableProperty.Create(
            propertyName: nameof(IsRightIconVisible),
            returnType: typeof(bool),
            declaringType: typeof(CustomNavBar));
        public bool IsRightIconVisible
        {
            get => (bool)GetValue(IsRightIconVisibleProperty);
            set => SetValue(IsRightIconVisibleProperty, value);
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