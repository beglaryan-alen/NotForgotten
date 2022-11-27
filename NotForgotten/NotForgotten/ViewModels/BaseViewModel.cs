using MvvmHelpers.Commands;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
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

        public ICommand GoBackCommand => new AsyncCommand(async() => await _navigation.PopModalAsync());

        #region INotifyPropertyChanged

        protected bool SetProperty<T>(ref T backingStore, T value,
           [CallerMemberName] string propertyName = "",
           Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        protected virtual void Initialize()
        {

        }
    }
}
