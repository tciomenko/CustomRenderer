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
        ButtonCircle buttonCircle;

        public ButtoniOSCircleRenderer(){
            buttonCircle = new ButtonCircle();

        }
         
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);


            buttonCircle = (ButtonCircle)this.Element;
            if (e.OldElement!= null)
            {

            }else if(e.NewElement!=null){
                
            }
            if(Control!=null){
                Control.Layer.CornerRadius = buttonCircle.BorderRadius;
                Control.ClipsToBounds = true;
                Control.SetBackgroundImage(UIImage.FromFile(buttonCircle.BackgroundImage),UIControlState.Normal);

                    
            }
        }


    }
}
