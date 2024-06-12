using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paypal payment = new Paypal();

            //IPaypalPayment payment = new PayonnerAdapter(new Payonner());

            IPaypalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PaypalPayment();
            payment.PaypalReceive();

            Console.ReadLine();
        }
    }
}
