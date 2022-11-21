using NotForgotten.Controls;
using NotForgotten.iOS.Renderers.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]
namespace NotForgotten.iOS.Renderers.Controls
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        #region -- Overrides --

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.BorderWidth = 0;

                Control.BorderStyle = UITextBorderStyle.None;
            }
        }

        #endregion

    }
}
