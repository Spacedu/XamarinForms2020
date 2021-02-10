using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.ViewModels
{
    public class TicketPaidHistoryViewModel : BaseViewModel
    {
        public List<Ticket> Tickets { get; set; }
        public TicketPaidHistoryViewModel()
        {
            Tickets = new TicketService().GetTicketsPaid();
        }
    }
}
