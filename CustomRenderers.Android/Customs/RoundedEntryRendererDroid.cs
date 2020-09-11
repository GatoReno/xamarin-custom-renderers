using System;
using Android.Graphics.Drawables;
using CustomRenderers.Customes;
using CustomRenderers.Droid.Customs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRendererDroid))]
namespace CustomRenderers.Droid.Customs
{
    [Obsolete]
    public class RoundedEntryRendererDroid : EntryRenderer
    {
        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.SetBackgroundResource(Resource.Layout.rounded_shape);
                //var gradientDrawable = new GradientDrawable();
                //gradientDrawable.SetCornerRadius(60f);
                //gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                //gradientDrawable.SetColor(Android.Graphics.Color.LightGray);
                //Control.SetBackground(gradientDrawable);
                //Control.SetPadding(50, Control.PaddingTop, Control.CompoundPaddingRight, Control.PaddingBottom);
            }
        }
    }
}
