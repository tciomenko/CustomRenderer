﻿using System;
namespace CustomRenderers.Models
{
    public class ImageCaruselModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        //URL for our monkey image!
        public string Image { get; set; }

        public string NameSort => Name[0].ToString();
    }
}
