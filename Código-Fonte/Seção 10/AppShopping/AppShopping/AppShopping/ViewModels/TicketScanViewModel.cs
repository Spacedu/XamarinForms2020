using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace AppShopping.ViewModels
{
    public class TicketScanViewModel : BaseViewModel
    {
        private string _ticketNumber;

        public string TicketNumber
        {
            get { return _ticketNumber; }
            set { SetProperty(ref _ticketNumber, value); }
        }

        public ICommand TicketTextChangedCommand { get; set; }

        public ICommand TicketScanCommand { get; set; }
        private string _message;
        public string Message { 
            get
            {
                return _message;
            }
            set
            {
                SetProperty(ref _message, value);
            }
        }
        public ICommand TicketPaidHistoryCommand { get; set; }
        public TicketScanViewModel()
        {
            TicketScanCommand = new MvvmHelpers.Commands.AsyncCommand(TicketScan);
            TicketTextChangedCommand = new Command(TicketTextChanged);
            TicketPaidHistoryCommand = new Command(TicketPaidHistory);
        }
        private async Task TicketScan()
        {
            var scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += async (result) =>
            {
                scanPage.IsScanning = false;
                Device.BeginInvokeOnMainThread(async() =>
                {
                    await Shell.Current.Navigation.PopAsync();
                    Message = result.Text;
                    TicketProccess(result.Text);
                });
            };
            
            await Shell.Current.Navigation.PushAsync(scanPage);
        }
        private void TicketTextChanged()
        {
            if(TicketNumber.Length == 15)
            {
                var ticketNumber = TicketNumber.Replace(" ", string.Empty);
                TicketProccess(ticketNumber);
            }
        }

        private async Task TicketProccess(string ticketNumber)
        {
            try
            {
                var ticket = new TicketService().GetTicketToPaid(ticketNumber);

                await Shell.Current.GoToAsync($"ticket/payment?number={ticketNumber}");

                TicketNumber = string.Empty;
            }
            catch(Exception e)
            {
                Message = e.Message;
            }
        }
        private void TicketPaidHistory()
        {
            Shell.Current.GoToAsync("ticket/paid/history");
        }
    }
}
