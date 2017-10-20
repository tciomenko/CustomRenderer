using System;
using Xamarin.Forms;
namespace CustomRenderers.Controls
{
    public class VideoPlayer:View
    {


        public Action TogglePlay { get; set; }
        public Action Stop { get; set; }
        public Action Play { get; set; }
        public Action HideFullScreenButton { get; set; }

        public event EventHandler<bool> PlaybackStateChanged;
        public event EventHandler PlaybackFinished;



        public static BindableProperty VideoPathProperty = BindableProperty.Create<VideoPlayer, string>(o => o.VideoPath, "");

        public string VideoPath
        {
            get { return (string)GetValue(VideoPathProperty); }
            set { SetValue(VideoPathProperty, value); }
        }



        public static BindableProperty ShowControlsProperty = BindableProperty.Create<VideoPlayer, bool>(o => o.ShowControls, true);

        public bool ShowControls
        {
            get { return (bool)GetValue(ShowControlsProperty); }
            set { SetValue(ShowControlsProperty, value); }
        }



        public void FirePlaybackStateChanged(object sender, bool isPlaying)
        {
            PlaybackStateChanged?.Invoke(sender, isPlaying);
        }


        public void FirePlaybackFinished(object sender, EventArgs args)
        {
            PlaybackFinished?.Invoke(sender, args);
        }



    }
}