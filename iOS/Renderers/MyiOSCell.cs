using System;
using CoreGraphics;
using CustomRenderers.Views;
using CustomRenderers;
using UIKit;
using Xamarin.Forms;

namespace CustomRenderers.iOS.Renderers
{
    public class MyiOSCell:UITableViewCell,INativeElementView
    {
        public UILabel NameLabel { get; set; }
        public UILabel TimeLabel { get; set; }
        public UILabel EventLable { get; set; }
        public UIImageView CellImageView { get; set;}
        public MyCell MyCell;
        public Element Element => MyCell;

        public MyiOSCell(string cellId,MyCell cell):base(UITableViewCellStyle.Default,cellId)
        {
            MyCell = cell;
            SelectionStyle = UITableViewCellSelectionStyle.Gray;
            ContentView.BackgroundColor = UIColor.FromRGB(255, 255, 255);
            CellImageView = new UIImageView();
            NameLabel = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 22f),
                TextColor = UIColor.FromRGB(127, 51, 0),
                BackgroundColor = UIColor.Clear
            };

            TimeLabel = new UILabel()
            {
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.FromRGB(38, 127, 0),
                TextAlignment = UITextAlignment.Center,
                BackgroundColor = UIColor.Clear
            };
            ContentView.Add(NameLabel);
            ContentView.Add(TimeLabel);
            ContentView.Add(CellImageView);
        }

        public void UpdateCell(MyCell cell)
        {
            NameLabel.Text = cell.Name;
            TimeLabel.Text = cell.Time;
            CellImageView.Image = GetImage(cell.ImageFilename);
        }

        public UIImage GetImage(string filename)
        {
            return (!string.IsNullOrWhiteSpace(filename)) ? UIImage.FromFile("Images/" + filename + ".jpg") : null;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            NameLabel.Frame = new CGRect(5, 4, ContentView.Bounds.Width - 63, 25);
            TimeLabel.Frame = new CGRect(100, 18, 100, 20);
            CellImageView.Frame = new CGRect(ContentView.Bounds.Width - 63, 5, 33, 33);
        }
    }
}
