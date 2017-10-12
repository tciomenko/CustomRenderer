using System;
using CoreGraphics;
using CustomRenderers.iOS.Helpers;
using CustomRenderers.Views;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace CustomRenderers.iOS.Native
{
    public class FriendNativeCell : UITableViewCell
    {
        UIView _view;
        object _originalBindingContext;
        public FriendCell friendCell;

        public FriendNativeCell(string cellId, FriendCell frCell) : base(UITableViewCellStyle.Default, cellId)
        {
            friendCell = frCell;
            _originalBindingContext = frCell.BindingContext;
            var renderer = Platform.CreateRenderer(frCell.View);
            _view = renderer.NativeView;
            ContentView.AddSubview(_view);


        }
        public void RecycleCell(FriendCell newCell)
        {
            if (newCell == friendCell)
                friendCell.BindingContext = _originalBindingContext;
            else
                friendCell.BindingContext = newCell.BindingContext;
            
        }
        CGSize _lastSize;
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            //TODO update sizes of the xamarin view
            if (_lastSize.Equals(CGSize.Empty) || !_lastSize.Equals(Frame.Size))
            {

                var layout = friendCell.View as Layout<View>;
                if (layout != null)
                {   
                    layout.Layout(Frame.ToRectangle());
                    
                    layout.ForceLayout();

                    FixChildLayouts(layout);
                }
                _lastSize = Frame.Size;
            }

            _view.Frame = ContentView.Bounds;
        }
        void FixChildLayouts(Layout<View> layout)
        {
            foreach (var child in layout.Children)
            {
                switch (child)
                {
                    case StackLayout stack:
                        FixChild((StackLayout)child);
                        break;
                    case AbsoluteLayout absolute:
                        FixChild((AbsoluteLayout)child);
                        break;
                    case Grid grid:
                        FixChild((Grid)child);
                        break;
                }
            }
        }

        void FixChild(Layout<View> child)
        {
            child.ForceLayout();
            FixChildLayouts(child as Layout<View>);
        }
    }
}

