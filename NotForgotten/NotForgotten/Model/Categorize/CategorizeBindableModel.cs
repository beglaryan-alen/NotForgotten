using Prism.Mvvm;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotForgotten.Model.Categorize
{
    public class CategorizeBindableModel : BindableBase
    {

        #region -- Public properties --

        private List<string> _collection;
        public List<string> Collection
        {
            get => _collection;
            set => SetProperty(ref _collection, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private bool _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded;
            set => SetProperty(ref _isExpanded, value);
        }

        public ICommand ItemTapped => new Command(ExpandItem);

        #endregion

        #region -- Private helpers --

        private void ExpandItem()
        {
            IsExpanded = !IsExpanded;
        }

        #endregion

    }
}
