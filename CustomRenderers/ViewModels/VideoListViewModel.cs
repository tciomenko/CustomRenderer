using System;
using System.Collections.Generic;
using System.ComponentModel;
using CustomRenderers.Models;

namespace CustomRenderers.ViewModels
{
    public class VideoListViewModel:INotifyPropertyChanged
    {
        private List<VideoCellModel> videoList=new List<VideoCellModel>();
        public VideoListViewModel()
        {
            VideoList = new List<VideoCellModel>();
            VideoList.Add(new VideoCellModel() { Image = "", Name = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4", Time = "3:51" });
            VideoList.Add(new VideoCellModel() { Image = "", Name = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4", Time = "3:51" });
            VideoList.Add(new VideoCellModel() { Image = "", Name = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4", Time = "3:51" });
            VideoList.Add(new VideoCellModel() { Image = "", Name = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4", Time = "3:51" });
            VideoList.Add(new VideoCellModel() { Image = "", Name = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4", Time = "3:51" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public List<VideoCellModel> VideoList{
            get {
                return videoList; 
                }
            set {
                videoList = value;
                OnPropertyChanged(nameof(VideoList));
                }
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
