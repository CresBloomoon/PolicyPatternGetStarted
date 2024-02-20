using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyPatternGetStarted {
    internal sealed class SilverCustomerPolicy {
        private readonly ExcellentCustomerPolicy _policy;

        SilverCustomerPolicy() {
            _policy = new ExcellentCustomerPolicy();
            _policy.Add(new PurchaseFrequencyRule());
            _policy.Add(new ReturnRateRule());
        }

        public bool ComplyWithAll(PurchaseHistory history) {
            return _policy.ComplyWithAll(history);
        }
    }
}
