using System;


namespace Adapter
{
    class MercadoPagoAdapter : IPaypalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;

            Console.WriteLine("Realizando adaptação de Payonner para os métodos do MercadoPago. ");
        }
        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PaypalPayment()
        {
            mercadoPago.SendMercadoPago();
        }

        public void PaypalReceive()
        {
            mercadoPago.MercadoPagoReceive();
        }
    }
}
