
using System;

namespace Adapter
{
    class PayonnerAdapter : IPaypalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter( Payonner payonner)
        {        
            this.payonner = payonner;

            Console.WriteLine("Realizando adaptação de Payonner para os métodos do Paypal. ");
        }
        public Token AuthToken() 
        {
           return this.payonner.AuthToken();
        }
        public void PaypalPayment()
        {
            this.payonner.SendPayment();
        }
        public void PaypalReceive()
        {
            this.payonner.ReceivePayment();
        }
    }
}
