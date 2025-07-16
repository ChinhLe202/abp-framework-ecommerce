using System;
using System.Collections.Generic;
using System.Text;

namespace ABP_Ecommerce.Orders
{
    public enum PaymentMethod
    {
        COD = 1,
        OnlinePayment = 2,
        TransferByBank = 3,
        CreditCard = 4,
    }
}
