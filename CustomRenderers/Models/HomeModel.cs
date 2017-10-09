using System;
using System.Collections.Generic;

namespace CustomRenderers.Models
{
    public class HomeModel
    {
        public string BackgroundImage { get; set; }
        public string UserImage { get; set; }
        public List<MyCellModel> ListCell { get; set; }
        public HomeModel(){
            ListCell =new List<MyCellModel>();
        }
    }
}
