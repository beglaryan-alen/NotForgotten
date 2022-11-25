using Android.Content;
using Android.Graphics;
using Android.Service.Controls;
using NotForgotten.Controls;
using NotForgotten.Droid.Renderers.Controls;
using NotForgotten.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

namespace NotForgotten.Droid.Renderers.Controls
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        public CustomTabbedPageRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
        }
    }
}