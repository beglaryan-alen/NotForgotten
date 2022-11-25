using NotForgotten.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotForgotten.Controls
{
    public partial class CarouselTabIndicatorView : Frame
    {
        private List<TabElementBindableModel> _tabCollection;

        public CarouselTabIndicatorView()
        {
            InitializeComponent();
        }

        #region -- Public properties --

        public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create(
            propertyName: nameof(SelectedIndex),
            returnType: typeof(int),
            declaringType: typeof(CarouselTabIndicatorView),
            defaultBindingMode: BindingMode.TwoWay);

        public int SelectedIndex
        {
            get => (int)GetValue(SelectedIndexProperty);
            set => SetValue(SelectedIndexProperty, value);
        }

        public static readonly BindableProperty SelectedTabColorProperty = BindableProperty.Create(
           propertyName: nameof(SelectedTabColor),
           returnType: typeof(Color),
           declaringType: typeof(CarouselTabIndicatorView));

        public Color SelectedTabColor
        {
            get => (Color)GetValue(SelectedTabColorProperty);
            set => SetValue(SelectedTabColorProperty, value);
        }

        public static readonly BindableProperty SelecteTabTextColorProperty = BindableProperty.Create(
           propertyName: nameof(SelecteTabTextColor),
           returnType: typeof(Color),
           declaringType: typeof(CarouselTabIndicatorView));

        public Color SelecteTabTextColor
        {
            get => (Color)GetValue(SelecteTabTextColorProperty);
            set => SetValue(SelecteTabTextColorProperty, value);
        }

        public static readonly BindableProperty UnSelecteTabTextColorProperty = BindableProperty.Create(
           propertyName: nameof(UnSelecteTabTextColor),
           returnType: typeof(Color),
           declaringType: typeof(CarouselTabIndicatorView));

        public Color UnSelecteTabTextColor
        {
            get => (Color)GetValue(UnSelecteTabTextColorProperty);
            set => SetValue(UnSelecteTabTextColorProperty, value);
        }

        public static readonly BindableProperty TabFontFamilyProperty = BindableProperty.Create(
           propertyName: nameof(TabFontFamily),
           returnType: typeof(string),
           declaringType: typeof(CarouselTabIndicatorView));

        public string TabFontFamily
        {
            get => (string)GetValue(TabFontFamilyProperty);
            set => SetValue(TabFontFamilyProperty, value);
        }

        public static readonly BindableProperty TabFontSizeProperty = BindableProperty.Create(
           propertyName: nameof(TabFontSize),
           returnType: typeof(double),
           declaringType: typeof(CarouselTabIndicatorView));

        public double TabFontSize
        {
            get => (double)GetValue(TabFontSizeProperty);
            set => SetValue(TabFontSizeProperty, value);
        }

        public static readonly BindableProperty TabLabelsProperty = BindableProperty.Create(
            propertyName: nameof(TabLabels),
            returnType: typeof(IEnumerable<string>),
            declaringType: typeof(CarouselTabIndicatorView));

        public IEnumerable<string> TabLabels
        {
            get => (IEnumerable<string>)GetValue(TabLabelsProperty);
            set => SetValue(TabLabelsProperty, value);
        }

        #endregion

        #region -- Overrides --

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (TabLabelsProperty.PropertyName == propertyName)
            {
                CreateTabs();
            }
        }

        #endregion

        #region -- Private helpers --

        private void CreateTabs()
        {
            if (TabLabels?.Any() ?? false)
            {
                var collection = new List<TabElementBindableModel>();

                for (int i = 0; i < TabLabels.Count(); i++)
                {
                    var element = new TabElementBindableModel
                    {
                        Index = i,
                        FontFamily = TabFontFamily,
                        FontSize = TabFontSize,
                        TextColor = i == 0 ? SelecteTabTextColor : UnSelecteTabTextColor,
                        IsSelected = i == 0,
                        Title = TabLabels.ToList()[i],
                        TapCommand = new Command<TabElementBindableModel>(OnTapCommand),
                    };
                    if (i == 0)
                        element.IconSource = "cards_icon";
                    else if (i == 1)
                        element.IconSource = "home_icon";
                    else if (i == 2) 
                        element.IconSource = "shop_icon";
                    else
                        element.IconSource = "settings_icon";
                    collection.Add(element);
                }

                _tabCollection = collection;

                //SelectTab(0);

                BindableLayout.SetItemsSource(container, _tabCollection);
                InvalidateLayout();
            }
        }

        private void OnTapCommand(TabElementBindableModel element)
        {
            if (element != null)
            {
                SelectedIndex = element.Index;

                SelectTab(element.Index);
            }
        }

        private void SelectTab(int index)
        {
            if ((_tabCollection?.Any() ?? false) && index >= 0 && index < _tabCollection.Count)
            {
                foreach (var item in _tabCollection)
                {
                    item.IsSelected = false;
                    item.TextColor = UnSelecteTabTextColor;
                }

                _tabCollection[index].IsSelected = true;
                _tabCollection[index].TextColor = SelecteTabTextColor;
            }
        }

        #endregion
    }
}