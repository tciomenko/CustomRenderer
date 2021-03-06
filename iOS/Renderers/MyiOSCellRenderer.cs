﻿using CustomRenderers;
using CustomRenderers.iOS;
using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CustomRenderers.Views;
using CustomRenderers.iOS.Renderers;
using CustomRenderers.iOS.Native;

[assembly:ExportRenderer(typeof(MyCell),typeof(MyiOSCellRenderer))]
namespace CustomRenderers.iOS.Renderers
{
    public class MyiOSCellRenderer:ViewCellRenderer
    {
        MyiOSCell cell;
        public override UITableViewCell GetCell(Cell item,UITableViewCell reusableCell,UITableView tv){
            var myCell = (MyCell)item;
            cell = reusableCell as MyiOSCell;
            if(cell==null){
                cell = new MyiOSCell(item.GetType().FullName, myCell);
            }
            else{
                myCell.PropertyChanged -= OnMyCellPropertyChanged;

            }
            cell.UpdateCell(myCell);

            return cell;
        }
        
        void OnMyCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
            var myCell = (MyCell)sender;
            if (e.PropertyName == MyCell.NameProperty.PropertyName)
            {
                cell.NameLabel.Text = myCell.Name;
            }
            else if (e.PropertyName == MyCell.TimeProperty.PropertyName)
            {
                cell.TimeLabel.Text = myCell.Time;
            }
            else if (e.PropertyName == MyCell.TimeProperty.PropertyName)
            {
                cell.EventLabel.Text = myCell.EventFriends;
            }
            else if (e.PropertyName == MyCell.ImageFileNameProperty.PropertyName)
            {
                //cell.ImageCircle.Element.Source = ImageSource.FromFile(myCell.ImageFileName);
                //cell.ImageCircle.Control.Image = UIImage.FromFile(myCell.ImageFileName);
            }
        }
    }
}
