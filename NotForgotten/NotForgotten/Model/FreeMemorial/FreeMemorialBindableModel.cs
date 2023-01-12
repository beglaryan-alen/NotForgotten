using Prism.Mvvm;
using System;

namespace NotForgotten.Model.FreeMemorial
{
    public class FreeMemorialBindableModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _belongName;
        public string BelongName
        {
            get => _belongName;
            set => SetProperty(ref _belongName, value);
        }

        private DateTime _date;
        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }
    }
}
