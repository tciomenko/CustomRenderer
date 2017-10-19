using System;
using AVFoundation;
using CustomRenderers.Controls;
using UIKit;
using CoreGraphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;

namespace CustomRenderers.iOS.Renderers
{
    public class ViewiOSPlayer:UIView,INativeElementView
    {
        public AVPlayer player;
        public AVPlayerLayer playerLayer;
        public AVAsset asset;
        public AVPlayerItem playerItem;
        public ViewiOSPlayer()
        {
            player = new AVPlayer();

            asset = AVAsset.FromUrl(new NSUrl("http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4/"));
            playerItem = new AVPlayerItem(asset);
            playerLayer = AVPlayerLayer.FromPlayer(player);

            Layer.AddSublayer(playerLayer);

        }
        public VideoPlayer VideoPlayer;
        public Element Element => VideoPlayer;

    }
}
