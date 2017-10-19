using System;
using Plugin.MediaManager.Forms;
using Plugin.MediaManager;
using Xamarin.Forms;

namespace CustomRenderers.Behaviors
{
    public static class VideoMenuBehavior
    {
        public static readonly BindableProperty AttachBehaviorProperty =
        BindableProperty.CreateAttached(
            "AttachBehavior",
            typeof(bool),
                typeof(VideoMenuBehavior),
            false,
            propertyChanged: OnAttachBehaviorChanged);

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }

        static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            var element = view as VideoView;
            if (element == null)
            {
                return;
            }
            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                element.Focused += OnEntryVideoChanged;
            }
            else
            {
                element.Focused -= OnEntryVideoChanged;
            }
        }

        static void OnEntryVideoChanged(object sender, FocusEventArgs args)
        {
            double result;
            result = 10;

        }
    }
}
