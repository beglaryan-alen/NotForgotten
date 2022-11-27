using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace NotForgotten.Controls
{
    public partial class CategorizeBindableItems : Frame
	{
		public CategorizeBindableItems ()
		{
			InitializeComponent();
        }

        public static readonly BindableProperty LabelsProperty = BindableProperty.Create(
           propertyName: nameof(Labels),
           returnType: typeof(IEnumerable<string>),
           declaringType: typeof(CategorizeBindableItems));
        public IEnumerable<string> Labels
        {
            get => (IEnumerable<string>)GetValue(LabelsProperty);
            set => SetValue(LabelsProperty, value);
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
           propertyName: nameof(Title),
           returnType: typeof(string),
           declaringType: typeof(CategorizeBindableItems));
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            if (Labels != null && Labels.Count() > 13 &&
                !(collectionView.ItemsLayout is GridItemsLayout))
            {
                collectionView.ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);
            }

            if (expander.IsExpanded)
            {
                arrowImage.RotateTo(0);
            }
            else
            {
                arrowImage.RotateTo(180);
            }
        }
    }
}