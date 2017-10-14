using System;
using CustomRenderers.Models;
using Xamarin.Forms;

namespace CustomRenderers.Selectors
{
    public class HomeTemplateSelector:DataTemplateSelector
    {
        public DataTemplate EventTemplate { get; set; }
        public DataTemplate BirthdayTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            return ((MyCellModel)item).Name == "Юлия" ? EventTemplate : BirthdayTemplate;
        }
    }
}
