using Prism.Mvvm;

namespace NotForgotten.Model.OtherFormat
{
    public class OtherFormatBindableModel : BindableBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _isDownloaded;
        public bool IsDownloaded
        {
            get => _isDownloaded;
            set => SetProperty(ref _isDownloaded, value);
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
