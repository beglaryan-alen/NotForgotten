using NotForgotten.ViewModels;
using System;
using Xamarin.Forms;

namespace NotForgotten.Views
{
    public partial class RootView : ContentPage
    {
        public RootView(int position, bool isVertical = false)
        {
            InitializeComponent();
            BindingContext = new RootViewModel(Navigation, position, isVertical);
        }
    }
}