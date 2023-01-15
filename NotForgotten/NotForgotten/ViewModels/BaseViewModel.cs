﻿using MvvmHelpers.Commands;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Prism.Mvvm;
using System.Linq;
using NotForgotten.Views;

namespace NotForgotten.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        protected readonly IPopupNavigation _popupNavigation;
        protected readonly INavigation _navigation;
        public BaseViewModel(
            INavigation navigation)
        {
            _popupNavigation = DependencyService.Get<IPopupNavigation>();
            _navigation = navigation;
            Initialize();
        }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title , value);
        }

        public ICommand GoBackCommand => new AsyncCommand(async() => await _navigation.PopModalAsync());

        protected virtual void Initialize()
        {
        }
    }
}
