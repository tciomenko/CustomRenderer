using System;
using System.ComponentModel;

namespace CustomRenderers.Models
{
    public class MyCellModel
    {
        public string Name { get; set; }
        public string Time { get; set; }
        public string ImageFileName{ get; set; }
        public string EventFriends{ get; set; }
        public Type TargetType { get;  set; }
    }
}
