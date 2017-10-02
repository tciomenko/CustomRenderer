using System;
using CustomRenderers;
using CustomRenderers.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(HomeViewCell), typeof(HomeViewCellRenderer))]
namespace CustomRenderers.iOS.Renderers
{
	public class HomeViewCellRenderer : ViewCellRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				// do whatever you want to the UITextField here!
				Control.BackgroundColor = UIColor.Green;
				Control.BorderStyle = UITextBorderStyle.Line;
			}
		}
	}
}
