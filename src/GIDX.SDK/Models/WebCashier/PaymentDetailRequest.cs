﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIDX.SDK.Models.WebCashier
{
    public class PaymentDetailRequest : RequestBase
    {
        public string MerchantTransactionID { get; set; }
    }
}
