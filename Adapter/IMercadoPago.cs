using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface IMercadoPago
    {
        Token AuthToken();
        void SendMercadoPago();
        void MercadoPagoReceive();
    }
}
