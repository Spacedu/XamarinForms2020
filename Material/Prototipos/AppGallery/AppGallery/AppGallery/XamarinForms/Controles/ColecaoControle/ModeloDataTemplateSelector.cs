using AppGallery.XamarinForms.Controles.ListaControle;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppGallery.XamarinForms.Controles.ColecaoControle
{
    public class ModeloDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TemplateNormal { get; set; }
        public DataTemplate TemplateTurbo { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var modelo = (Modelo)item;

            return modelo.Motor.Contains("T") ? TemplateTurbo : TemplateNormal ;
        }
    }
}
