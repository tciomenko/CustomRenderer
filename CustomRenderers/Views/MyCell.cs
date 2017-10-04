using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class MyCell:ViewCell
    {
        //Label nameLabel, timeLabel, eventFriendsLabel;
        
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
            set { SetValue(TimeProperty, value);}
        }

        public static readonly BindableProperty ImageFilenameProperty =
          BindableProperty.Create("ImageFilename", typeof(string), typeof(MyCell), "");

        public string ImageFilename
        {
            get { return (string)GetValue(ImageFilenameProperty); }
            set { SetValue(ImageFilenameProperty, value); }
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