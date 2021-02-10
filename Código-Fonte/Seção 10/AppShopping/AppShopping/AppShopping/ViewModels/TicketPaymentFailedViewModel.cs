using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    [QueryProperty("Number", "number")]
    [QueryProperty("Message", "message")]
    public class TicketPaymentFailedViewModel : BaseViewModel
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set {
                SetProperty(ref _message, Uri.UnescapeDataString(value));
            }
        }

        private string _number;
        public String Number
        {
            set
            {
                SetProperty(ref _number, value);

                Ticket = _ticketService.GetTicket(value);
            }
        }


        private Ticket _ticket;

        public Ticket Ticket
        {
            get { return _ticket; }
            set {
                SetProperty(ref _ticket, value);
            }
        }

        public ICommand OKCommand { get; set; }
        
        private TicketService _ticketService;
        public TicketPaymentFailedViewModel()
        {
            OKCommand = new Command(OK);

            _ticketService = new TicketService();
        }

        private void OK()
        {
            Shell.Current.Navigation.PopAsync();
        }

    }
}
