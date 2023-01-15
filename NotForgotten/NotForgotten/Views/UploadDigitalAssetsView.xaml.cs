﻿using NotForgotten.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UploadDigitalAssetsView : ContentPage
    {
        public UploadDigitalAssetsView(bool isArchive = false)
        {
            InitializeComponent();
            BindingContext = new UploadDigitalAssetsViewModel(Navigation, isArchive);
        }
    }
}