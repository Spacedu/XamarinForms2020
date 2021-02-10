using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Libraries.Validators;
using AppShopping.Models;
using AppShopping.Services;
using Plugin.PayCards;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    [QueryProperty("Number", "number")]
    public class TicketPaymentViewModel : BaseViewModel
    {
        private string _messages;

        public string Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        private string _number;
        public String Number
        {
            set
            {
                SetProperty(ref _number, value);

                Ticket = _ticketService.GetTicketToPaid(value);
            }
        }

        private Ticket _ticket;

        public Ticket Ticket
        {
            get { return _ticket; }
            set
            {
                SetProperty(ref _ticket, value);
            }
        }

        private CreditCard _creditCard;

        public CreditCard CreditCard
        {
            get { return _creditCard; }
            set
            {
                SetProperty(ref _creditCard, value);
            }
        }

        public ICommand PaymentCommand { get; set; }
        public ICommand CreditCardScanCommand { get; set; }

        private TicketService _ticketService;
        private PaymentService _paymentService;
        public TicketPaymentViewModel()
        {
            _ticketService = new TicketService();
            _paymentService = new PaymentService();

            CreditCard = new CreditCard();

            PaymentCommand = new MvvmHelpers.Commands.AsyncCommand(Payment);
            CreditCardScanCommand = new MvvmHelpers.Commands.AsyncCommand(CreditCardScan);
        }

        private async Task Payment()
        {
            //Tipos de validação: Manual, Data Annotations e Fluent Validation.
            try
            {
                Messages = string.Empty;

                string messages = Valid(CreditCard);

                if (string.IsNullOrEmpty(messages))
                {
                    //PagSeguro, PayPal, Pagar.Me etc. Cliente*, Crédito e Produto/Serviço (Preço).
                    //Cielo, Visa, Elo, MasterCard.
                    string transactionId = _paymentService.SendPayment(CreditCard, Ticket);
                    Ticket.TransactionId = transactionId;
                    Ticket.Status = Libraries.Enums.TicketStatus.paid;

                    _ticketService.UpdateTicket(Ticket);

                    await Shell.Current.GoToAsync($"ticket/payment/success?number={Ticket.Number}");
                }
                else
                {
                    Messages = messages;
                }
            }
            catch (Exception e)
            {
                await Shell.Current.GoToAsync($"ticket/payment/failed?number={Ticket.Number}&message={e.Message}");
            }
        }
        private string Valid(CreditCard creditCard)
        {
            StringBuilder messages = new StringBuilder();

            if (string.IsNullOrEmpty(creditCard.Name))
            {
                messages.Append("O nome não foi preenchido!" + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(creditCard.Number))
            {
                messages.Append("O número do cartão não foi preenchido!" + Environment.NewLine);
            }
            else if (creditCard.Number.Length < 19)
            {
                messages.Append("O número do cartão está incompleto!" + Environment.NewLine);
            }

            try
            {
                var firstTwoCharYear = DateTime.Now.Year.ToString().Substring(0, 2);

                var expiredString = creditCard.Expired.Split('/');
                var month = int.Parse(expiredString[0]);
                var year = int.Parse(firstTwoCharYear + expiredString[1]);

                var expireDate = new DateTime(year, month, 01);
                var now = DateTime.Now;
                
                if (
                        expireDate.Year < now.Year || 
                        (expireDate.Month < now.Month && expireDate.Year == now.Year))
                {
                    messages.Append("Cartão expirado!" + Environment.NewLine);
                }
            }
            catch (Exception e)
            {
                messages.Append("A validade do cartão não é válida!" + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(creditCard.SecurityCode))
            {
                messages.Append("O código de segurança não foi preenchido!" + Environment.NewLine);
            }
            else if (creditCard.SecurityCode.Length < 3)
            {
                messages.Append("O número do cartão está incompleto!" + Environment.NewLine);
            }

            if (string.IsNullOrEmpty(creditCard.Document))
            {
                messages.Append("O CPF não foi preenchido!" + Environment.NewLine);
            }
            else if (creditCard.Document.Length < 14)
            {
                messages.Append("O CPF está incompleto!" + Environment.NewLine);
            }
            else if (!CPFValidator.IsCpf(creditCard.Document))
            {
                messages.Append("O CPF é inválido!" + Environment.NewLine);
            }

            return messages.ToString();
        }

        private async Task CreditCardScan()
        {
            var cardInfo = await CrossPayCards.Current.ScanAsync();

            await Shell.Current.DisplayAlert("Mensagem: ", $"{cardInfo.HolderName}\n{cardInfo.CardNumber}\n{cardInfo.ExpirationDate}",  "OK");

            if(!string.IsNullOrEmpty(cardInfo.CardNumber))
            {
                CreditCard.Number = cardInfo.CardNumber;
            }

            if (!string.IsNullOrEmpty(cardInfo.HolderName))
            {
                CreditCard.Name = cardInfo.HolderName;
            }

            if (!string.IsNullOrEmpty(cardInfo.HolderName))
            {
                CreditCard.Expired = cardInfo.ExpirationDate;
            }

            OnPropertyChanged(nameof(CreditCard));
        }
    }
}
