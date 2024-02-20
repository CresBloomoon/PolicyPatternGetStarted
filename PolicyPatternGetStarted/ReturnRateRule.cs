﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyPatternGetStarted {
    internal sealed class ReturnRateRule : ExcellentCustomerRule {
        public bool OK(PurchaseHistory history) {
            return history.returnRate <= 0.001;
        }
    }
}
