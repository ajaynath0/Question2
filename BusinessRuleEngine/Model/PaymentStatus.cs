﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Model
{
    public class PaymentStatus
    {
        public string Message { get; set; }
        public bool IsOrderProcessed { get; set; }

        public bool IsNotificationSent { get; set; }
    }
}
