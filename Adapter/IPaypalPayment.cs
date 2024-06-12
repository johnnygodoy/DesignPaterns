
namespace Adapter
{
    internal interface IPaypalPayment
    {
        Token AuthToken();
        void PaypalPayment();
        void PaypalReceive();
    }
}
