using System;
using CustomRenderers.iOS.Renderers;
using CustomRenderers.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ButtonCircle), typeof(ButtoniOSCircleRenderer))]
namespace CustomRenderers.iOS.Renderers
{
    public class ButtoniOSCircleRenderer:ButtonRenderer
    {
        
        

        public override void Draw(CoreGraphics.CGRect rect)
        {
            base.Draw(rect);

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

             if (e.OldElement!= null)
            {

            }
            if(Control!=null){
                Control.Layer.CornerRadius = 100;
                Control.ClipsToBounds = true;
                Control.SetBackgroundImage(UIImage.FromFile("images1.jpg"),UIControlState.Normal);

                    
            }
        }


    }
}
