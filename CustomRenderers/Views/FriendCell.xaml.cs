using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class FriendCell : ViewCell
    {
        public FriendCell()
        {
            InitializeComponent();
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            
        }
        public static readonly BindableProperty NameProperty =
          BindableProperty.Create("Name", typeof(string), typeof(MyCell), "");

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly BindableProperty TimeProperty =
          BindableProperty.Create("Time", typeof(string), typeof(MyCell), "");

        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        public static readonly BindableProperty ImageFileNameProperty =
          BindableProperty.Create("ImageFileName", typeof(string), typeof(MyCell), "");

        public string ImageFileName
        {
            get { return (string)GetValue(ImageFileNameProperty); }
            set { SetValue(ImageFileNameProperty, value); }
        }

        public static readonly BindableProperty EventFriendsProperty =
          BindableProperty.Create("EventFriends", typeof(string), typeof(MyCell), "");

        public string EventFriends
        {
            get { return (string)GetValue(EventFriendsProperty); }
            set { SetValue(EventFriendsProperty, value); }
        }
    }
}
