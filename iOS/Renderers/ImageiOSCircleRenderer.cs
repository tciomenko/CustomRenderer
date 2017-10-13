using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CustomRenderers.Views;
using CustomRenderers.iOS.Renderers;
using System;
using CoreGraphics;

[assembly: ExportRenderer(typeof(ImageCircle), typeof(ImageiOSCircleRenderer))]
namespace CustomRenderers.iOS.Renderers
{
    public class ImageiOSCircleRenderer:ImageRenderer
    {
        public ImageCircle image;
        double min;
        public ImageiOSCircleRenderer()
        {
            image = new ImageCircle();
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
            if (Control == null || e.OldElement != null || Element == null )
                return;
            
            image = (ImageCircle)this.Element;
            if (Control != null)
            {
                if (image.CornerRadius != "0"&& image.CornerRadius != "")
                {
                    Control.Layer.CornerRadius = (float)Convert.ToDouble(image.CornerRadius);
                }
                else
                {
                    min = Math.Min(Element.WidthRequest, Element.HeightRequest);
                    Control.Layer.CornerRadius = (float)(min / 2.0);
                }

                Control.Image = UIImage.FromFile(image.ImageName);
                Control.Layer.MasksToBounds = false;
                Control.ClipsToBounds = true;
                //Control.Layer.ShadowRadius = 30f;
                //Control.Layer.ShadowColor =new CGColor(255,0,255);
                //Control.Layer.ShadowOpacity = 0.5f;



            }

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null) return;

            if (Element.Aspect == Aspect.Fill)
            {
                if (e.PropertyName == VisualElement.HeightProperty.PropertyName ||
                    e.PropertyName == VisualElement.WidthProperty.PropertyName)
                {
                    DrawFill();  
                }
            }
            else
            {
                if (e.PropertyName == Image.IsLoadingProperty.PropertyName
                    && !Element.IsLoading && Control.Image != null)
                {
                    DrawOther();
                }
            }
        }
        public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

        }
        private void DrawFill()
        {
            if (image.CornerRadius != "0"&&image.CornerRadius=="")
            {
                Control.Layer.CornerRadius = (float)Convert.ToDouble(image.CornerRadius);
            }
            else
            {
                min = Math.Min(Element.WidthRequest, Element.HeightRequest);
                Control.Layer.CornerRadius = (float)(min / 2.0);
            }
            Control.Layer.MasksToBounds = false;
            Control.ClipsToBounds = true;
        }
        private void DrawOther()
        {
            int height;
            int width;

            switch (Element.Aspect)
            {
                case Aspect.AspectFill:
                    height = (int)Control.Image.Size.Height;
                    width = (int)Control.Image.Size.Width;
                    height = MakeSquare(height, ref width);
                    break;
                case Aspect.AspectFit:
                    height = (int)Control.Image.Size.Height;
                    width = (int)Control.Image.Size.Width;
                    height = MakeSquare(height, ref width);
                    break;
                default:
                    throw new NotImplementedException();
            }

            UIImage image = Control.Image;
            var clipRect = new CGRect(0, 0, width, height);
            var scaled = image.Scale(new CGSize(width, height));
            UIGraphics.BeginImageContextWithOptions(new CGSize(width, height), false, 0f);
            UIBezierPath.FromRoundedRect(clipRect, Math.Max(width, height) / 2).AddClip();

            scaled.Draw(new CGRect(0, 0, scaled.Size.Width, scaled.Size.Height));
            UIImage final = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            Control.Image = final;
        }
        private int MakeSquare(int height, ref int width)
        {
            if (height < width)
            {
                width = height;
            }
            else
            {
                height = width;
            }
            return height;
        }
    }
}
