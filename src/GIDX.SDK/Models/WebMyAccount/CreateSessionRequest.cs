﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIDX.SDK.Models.WebMyAccount
{
    public class CreateSessionRequest : RequestBase
    {
        public string MerchantCustomerID { get; set; }
    }
}
