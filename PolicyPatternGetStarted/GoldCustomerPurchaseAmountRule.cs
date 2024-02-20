using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyPatternGetStarted {
    internal sealed class GoldCustomerPurchaseAmountRule : ExcellentCustomerRule {
        public bool OK(PurchaseHistory history) {
            return 100000 <= history.TotalAmount;
        }
    }
}
