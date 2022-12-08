using Prism.Mvvm;
using System;

namespace NotForgotten.Model.Home
{
    public class HomeBindableModel : BindableBase
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

        private bool _isFavorite;
        public bool IsFavorite
        {
            get => _isFavorite;
            set => SetProperty(ref _isFavorite, value);
        }

        private bool _isDownloaded;
        public bool IsDownloaded
        {
            get => _isDownloaded;
            set => SetProperty(ref _isDownloaded, value);
        }

        private bool _hasSettings;
        public bool HasSettings
        {
            get => _hasSettings;
            set => SetProperty(ref _hasSettings, value);
        }

        private double _downloadedSize;
        public double DownloadedSize
        {
            get => _downloadedSize;
            set => SetProperty(ref _downloadedSize, value);
        }

        private double _fileSize;
        public double FileSize
        {
            get => _fileSize;
            set => SetProperty(ref _fileSize, value);
        }
    }
}
