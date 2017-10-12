using System;
using CoreGraphics;
using CustomRenderers.Views;
using CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Foundation;

namespace CustomRenderers.iOS.Renderers
{
    public partial class MyiOSCell:UITableViewCell,INativeElementView
    {
        public UILabel NameLabel { get; set; }
        public UILabel TimeLabel { get; set; }
        public UILabel EventLabel { get; set; }
        public UIImageView CellImageView { get; set; }
        //public ImageiOSCircleRenderer ImageCircle { get; set; }
        public MyCell MyCell;
        public Element Element => MyCell;

        public MyiOSCell(string cellId, MyCell cell) : base(UITableViewCellStyle.Default, cellId)
        {
            MyCell = cell;
            SelectionStyle = UITableViewCellSelectionStyle.Gray;
            ContentView.BackgroundColor = UIColor.FromRGB(255, 255, 255);
            CellImageView = new UIImageView();

            NameLabel = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 22f),
                TextColor = UIColor.Black,
                BackgroundColor = UIColor.Clear
            };

            TimeLabel = new UILabel()
            {
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.DarkGray,
                BackgroundColor = UIColor.Clear
            };
            EventLabel = new UILabel()
            {
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.Black,
                BackgroundColor = UIColor.Clear
            };

            ContentView.Add(CellImageView);
            ContentView.Add(NameLabel);
            ContentView.Add(TimeLabel);
            ContentView.Add(EventLabel);

        }

        public void UpdateCell(MyCell cell)
        {
            NameLabel.Text = cell.Name;
            TimeLabel.Text = cell.Time;
            EventLabel.Text = cell.EventFriends;
            
            //ImageCircle.Element.Source = ImageSource.FromFile(cell.ImageFileName);  
            CellImageView.Image= GetImage(cell.ImageFileName);
            CellImageView.Layer.CornerRadius = 40f;

        }

        public UIImage GetImage(string filename)
        {
            return (!string.IsNullOrWhiteSpace(filename)) ? UIImage.FromFile(filename + ".jpg") : null;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            CellImageView.Frame = new CGRect(5, 0, 80, 80);
            NameLabel.Frame = new CGRect(100, 4, ContentView.Bounds.Width - 63, 25);
            TimeLabel.Frame = new CGRect(100, 30, 100, 20);
            EventLabel.Frame = new CGRect(150, 30, 100, 20);


        }
    }
}
