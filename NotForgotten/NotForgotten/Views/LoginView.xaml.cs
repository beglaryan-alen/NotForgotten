﻿using NotForgotten.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}