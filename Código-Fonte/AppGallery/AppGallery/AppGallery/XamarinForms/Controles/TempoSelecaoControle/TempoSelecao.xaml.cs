using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.TempoSelecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TempoSelecao : ContentPage
    {
        public TempoSelecao()
        {
            InitializeComponent();
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Time")
            {
                lblInformativo.Text = "Time alterado!!!";
            }
            
        }
    }
}