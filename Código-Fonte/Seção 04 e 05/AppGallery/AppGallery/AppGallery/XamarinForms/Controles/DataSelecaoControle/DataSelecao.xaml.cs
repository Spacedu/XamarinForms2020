using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.DataSelecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataSelecao : ContentPage
    {
        public DataSelecao()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblInformativo.Text = "Data antiga: " + e.OldDate.ToString("dd/MM/yyyy") + " - Data nova: " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}