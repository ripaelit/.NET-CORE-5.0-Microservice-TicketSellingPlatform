﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSale.Web.Models.Orders
{
    public class OrderSuspendViewModel
    {
        public string Error { get; set; }
        public bool IsSuccessful { get; set; }
    }
}