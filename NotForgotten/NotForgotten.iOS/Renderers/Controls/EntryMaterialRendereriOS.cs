using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;

namespace NotForgotten.iOS.Renderers.Controls
{
    public class EntryMaterialRendereriOS : MaterialEntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            EntryRemoveUnderLine();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            EntryRemoveUnderLine();
        }

        protected void EntryRemoveUnderLine()
        {
            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
                Control.Underline.Enabled = false;
                Control.Underline.DisabledColor = UIColor.Clear;
                Control.Underline.Color = UIColor.Clear;
                Control.Underline.BackgroundColor = UIColor.Clear;
                // Remove underline on focus
                Control.ActiveTextInputController.UnderlineHeightActive = 0f;
                // Remove placeholder background
                Control.PlaceholderLabel.BackgroundColor = UIColor.Clear;
            }
        }
    }
}
