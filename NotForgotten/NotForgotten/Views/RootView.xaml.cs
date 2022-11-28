using NotForgotten.ViewModels;
using System;
using Xamarin.Forms;

namespace NotForgotten.Views
{
    public partial class RootView : ContentPage
    {
        public RootView()
        {
            InitializeComponent();
            BindingContext = new RootViewModel(Navigation);
        }
    }
}