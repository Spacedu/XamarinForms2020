using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShopping
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : Shell
    {
        public Menu()
        {
            InitializeComponent();

            Routing.RegisterRoute("establishment/detail", typeof(Views.EstablishmentDetail));
            Routing.RegisterRoute("film/detail", typeof(Views.FilmDetail));
            Routing.RegisterRoute("ticket/paid/history", typeof(Views.TicketPaidHistory));
            Routing.RegisterRoute("ticket/payment", typeof(Views.TicketPayment));
            Routing.RegisterRoute("ticket/payment/success", typeof(Views.TicketPaymentSuccess));
            Routing.RegisterRoute("ticket/payment/failed", typeof(Views.TicketPaymentFailed));
        }
    }
}