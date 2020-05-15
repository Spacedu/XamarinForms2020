using AppGallery.AppBase.Models;
using AppGallery.AppBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirPaginaFixa(object sender, EventArgs e)
        {
            var eventArgs = (TappedEventArgs)e;

            Type tipo = null; 
            switch(eventArgs.Parameter){
                case "Inicio":
                    tipo = typeof(AppBase.Inicio);
                    break;
                case "Creditos":
                    tipo = typeof(AppBase.Creditos);
                    break;
                default:
                    break;
            }

            var pagina = new NavigationPage((Page)Activator.CreateInstance(tipo));

            ((MasterDetailPage)App.Current.MainPage).Detail = pagina;
            ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
        }
    }
}