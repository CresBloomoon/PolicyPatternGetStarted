using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyPatternGetStarted {
    internal interface ExcellentCustomerRule {
        bool OK(PurchaseHistory history);
    }
}
