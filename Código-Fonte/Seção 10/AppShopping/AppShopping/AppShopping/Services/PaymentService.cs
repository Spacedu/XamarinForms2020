using AppShopping.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.Services
{
    public class PaymentService
    {
        //Falta enviar para o Provedor de Pagamento: Ticket (Number), Valor e Dados do Cliente(Endereço) - Visa, Master, PagSeguro,.
        public string SendPayment(CreditCard creditCard, Ticket ticket)
        {
            if(creditCard.SecurityCode == "111")
            {
                throw new Exception("Código de segurança inválido!");
            }

            return "1";
        }
    }
}
