using System;
using System.ComponentModel;
using CustomRenderers.iOS.Native;
using CustomRenderers.iOS.Renderers;
using CustomRenderers.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FriendCell), typeof(FriendIOSCellRenderer))]
namespace CustomRenderers.iOS.Renderers
{
    public class FriendIOSCellRenderer:ViewCellRenderer
    {
        FriendNativeCell nativeCell;
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var friendCell = (FriendCell)item;
            nativeCell = reusableCell as FriendNativeCell;
            if (nativeCell == null)
            {
                
                nativeCell = new FriendNativeCell((Foundation.NSString)item.GetType().FullName, friendCell);

            }
            else
            {
                friendCell.PropertyChanged -= OnFriendCellPropertyChanged;

            }
            return nativeCell;
        }
        void OnFriendCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            var FriendCell = (FriendCell)sender;
            
        }

    }
}
